using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Watch.DAL;
using Watch.Extentions;
using Watch.Models;
using Watch.ViewModels;

namespace Watch.Areas.WatchAdmin.Controllers
{[Area("WatchAdmin")]
    public class ProductController : Controller
    { private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db,IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Product> products = _db.Products.Include(p => p.BrandCategory).ToList();

            ProductVM productVM = new ProductVM
            {
                Products = products,
                BrandCategories = _db.BrandCategories.Include(b => b.Category).Include(b => b.Brand)
            };
            return View(productVM);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList ( _db.Categories, "Id", "CategoryName" );
            ViewBag.Brands = new SelectList(_db.Brands, "Id", "BrandName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product,BrandCategory brandCategory)
        {
            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Price"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Count"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Description"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return NotFound();

            else
            {
                var id = 0;
                if (_db.BrandCategories.Any(b => b.BrandId == brandCategory.BrandId && b.CategoryId == brandCategory.CategoryId))
                {
                    id = _db.BrandCategories.FirstOrDefaultAsync(b => b.BrandId == brandCategory.BrandId && b.CategoryId == brandCategory.CategoryId).Id;
                }
                else
                {
                    BrandCategory newBrandCategory = new BrandCategory
                    {
                        BrandId = brandCategory.BrandId,
                        CategoryId = brandCategory.CategoryId
                    };
                    await _db.BrandCategories.AddAsync(newBrandCategory);
                    await _db.SaveChangesAsync();
                    id = newBrandCategory.Id;
                }
               

                if (!product.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Duzgun formati secin!");
                    return View();
                }

                if (product.Photo.ImageSize(300))
                {
                    ModelState.AddModelError("Photo", "300kb dan artiq olmaz!");
                    return View();
                }
                string folderName = Path.Combine("assets", "img");
                string fileName = await product.Photo.CopyImage(_env.WebRootPath, folderName);


                Product newproduct = new Product()
                {
                    Name = product.Name,
                    Count = product.Count,
                    Price = product.Price,
                    Description = product.Description,
                    Image = fileName,
                    BrandCategoryId = id
                };
                await _db.Products.AddAsync(newproduct);
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

   

        //public async Task<IActionResult> Update(int? id)
        //{if (id == null) return NotFound();
        //    Product product = await _db.Products.Include(p => p.Category).FirstOrDefaultAsync(p=>p.Id==id);
        //    if (product == null) return NotFound();
        //    return View(product);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public  async Task<IActionResult>Update(int?id,Product product)
        //{
        //    if (id == null) return View();
        //    Product dbProduct = await _db.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
        //    if (dbProduct == null) return NotFound();
        //    if (product.Photo != null)
        //    {
        //        if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
        //       ModelState["Price"].ValidationState == ModelValidationState.Invalid ||
        //       ModelState["Count"].ValidationState == ModelValidationState.Invalid ||
        //       ModelState["Description"].ValidationState == ModelValidationState.Invalid) return NotFound();

        //        if (!product.Photo.IsImage())
        //        {
        //            ModelState.AddModelError("Photo", "Duzgun format secin");
        //            return View();
        //        }
        //        if (product.Photo.ImageSize(250))
        //        {
        //            ModelState.AddModelError("Photo", "Kicik olcu secin");
        //            return View();
        //        }

        //        string folderName = Path.Combine("assets", "img");
        //        string fileName = Path.Combine(_env.WebRootPath, folderName, dbProduct.Image);

        //        if (System.IO.File.Exists(fileName)){
        //            System.IO.File.Delete(fileName);
        //        }

        //        string newImg = await product.Photo.CopyImage(_env.WebRootPath, folderName);
        //        dbProduct.Image = newImg;
        //    }
        //    dbProduct.Name = product.Name;
        //    dbProduct.Count = product.Count;
        //    dbProduct.Description = product.Description;
        //    dbProduct.Price = product.Price;

        //    await _db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}