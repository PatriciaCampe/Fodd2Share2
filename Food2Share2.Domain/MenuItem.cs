using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food2Share2.Domain
{
    public class MenuItem
    {
        public int Id { get; set; }
        public double ItemCost { get; set; }
        public bool IsVegan { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

    }
}
