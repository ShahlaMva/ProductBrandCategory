using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watch.Models;

namespace Watch.ViewModels
{
    public class ProductVM
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<BrandCategory> BrandCategories { get; set; }
    }
}
