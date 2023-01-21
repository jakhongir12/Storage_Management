using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Project__Warehouse_Management
{
    abstract class Product 
    {
        public abstract string Type { get; set; }
        public abstract string Brand { get; set; }
        public abstract string Model { get; set; }
        public abstract double Quantity { get; set; }
        public abstract string ID { get; set; }
        
    }
}
