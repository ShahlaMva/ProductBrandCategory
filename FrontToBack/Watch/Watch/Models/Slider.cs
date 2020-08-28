using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Watch.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(30)]
        public string Title { get; set; }
        [Required,StringLength(100)]
        public string Text { get; set; }
        [Required,StringLength(200)]
        public string Image { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

      
    }
}
