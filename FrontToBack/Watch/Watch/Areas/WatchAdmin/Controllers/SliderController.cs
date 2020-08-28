using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Watch.DAL;
using Watch.Extentions;
using Watch.Models;

namespace Watch.Areas.WatchAdmin.Controllers
{[Area("WatchAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid ||
                   ModelState["Text"].ValidationState == ModelValidationState.Invalid ||
                   ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Duzgun formati secin!");
                return View();
            }

            if (slider.Photo.ImageSize(300))
            {
                ModelState.AddModelError("Photo", "200kb dan artiq olmaz!");
                return View();
            }
            string folderName = Path.Combine("assets", "img");
            string fileName = await slider.Photo.CopyImage(_env.WebRootPath, folderName);

            Slider newslider = new Slider
            {
                Title = slider.Title,
                Text = slider.Text,
                Image = fileName

            };
            await _db.Sliders.AddAsync(newslider);
            await _db.SaveChangesAsync();

            return Redirect("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int? id)
        {
            if (id == null) return NotFound();

            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            string folderimg = Path.Combine("assets", "img");
            string filePath = Path.Combine(_env.WebRootPath, folderimg, slider.Image);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();


            return Redirect("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {if (id == null) return NotFound();
            Slider dbSlider = await _db.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();

            return View(dbSlider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Update(int?id,Slider slider)
        {if (id == null) return NotFound();
            Slider dbSlider = await _db.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();
            if (slider.Photo != null)
            {
                if (

                   ModelState["Title"].ValidationState == ModelValidationState.Invalid ||
                   ModelState["Text"].ValidationState == ModelValidationState.Invalid) return NotFound();
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Duzgun format daxil edin!");
                    return View();
                }
                if (slider.Photo.ImageSize(300))
                {
                    ModelState.AddModelError("Photo", "Kicik olcu daxil edin!");
                    return View();
                }
              

                string folderimg = Path.Combine("assets", "img");
                string filePath = Path.Combine(_env.WebRootPath, folderimg, dbSlider.Image);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
                string newPhoto = await slider.Photo.CopyImage(_env.WebRootPath, folderimg);
                dbSlider.Image = newPhoto;

               
            }
            dbSlider.Title = slider.Title;
            dbSlider.Text = slider.Text;


            await _db.SaveChangesAsync();
           


               

                
          
            return RedirectToAction(nameof(Index));
        }
    }
}