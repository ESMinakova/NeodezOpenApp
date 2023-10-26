using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeodezMobApp.ViewModels
{
    public  class OrderWithDescriptionViewModel
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public CategoryViewModel Category { get; set; }

        public DateTime OrderTime { get; set; }
    }
}
