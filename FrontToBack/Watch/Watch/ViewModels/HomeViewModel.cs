using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watch.Models;

namespace Watch.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        //public IEnumerable<Product> Products { get; set; }
        public IEnumerable<WatchImage> WatchImages { get; set; }
    }
}
