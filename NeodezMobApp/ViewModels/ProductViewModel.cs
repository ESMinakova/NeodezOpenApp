using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeodezMobApp.ViewModels
{
    public class ProductViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string IconImagePath { get; set; }

        public string ProductImagePath { get; set; }

        public string Description { get; set; }

        public CategoryViewModel Category{ get; set; }

    }
}
