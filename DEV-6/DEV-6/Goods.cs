using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Goods
    {
        public String type { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public double costPerUnit { get; set; }

        public Goods() {}
        public Goods(String type, String name, int quantity, double costPerUnit)
        {
            this.type = type;
            this.name = name;
            this.quantity = quantity;
            this.costPerUnit = costPerUnit;
        }
    }
}