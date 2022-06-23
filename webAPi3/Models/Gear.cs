using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPi3.Models
{
    public class Gear
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string price { get; set; }

        public bool stock { get; set; }
    }
}
