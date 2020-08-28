using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watch.Models
{
    public class BrandCategory
    {
        public int Id { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
