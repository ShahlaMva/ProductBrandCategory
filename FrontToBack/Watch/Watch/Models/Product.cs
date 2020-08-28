using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public float Price { get; set; }

        public string Description { get; set; }
        [Required]
        public int Count { get; set; }

        public DateTime Time { get; set; }

        public bool Delete { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        public int BrandCategoryId { get; set; }

        public virtual BrandCategory BrandCategory { get; set; }
    }
}
