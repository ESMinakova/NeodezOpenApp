using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeodezMobApp.Models
{
    internal class Order
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime OrderTime { get; set; }
    }
}
