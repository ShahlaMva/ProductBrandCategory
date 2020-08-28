using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watch.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<BrandCategory> BrandCategories { get; set; }
    }
}
