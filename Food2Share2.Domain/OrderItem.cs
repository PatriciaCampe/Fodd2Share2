using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food2Share2.Domain
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemCount { get; set; }
        public MenuItem Item { get; set; }
    }
}
