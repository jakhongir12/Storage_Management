using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Project__Warehouse_Management
{
    internal class Laptop : Product
    {
        public override string Type { get; set; }
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override double Quantity { get; set; }
        public override string ID { get; set; }

        public string Battery, Prrocessor, Memory, GraphicCard, OS, Photo;

        public Laptop(string battery, string prrocessor, string memory, string graphicCard, string oS,string photo)
        {
            this.Battery = battery;
            this.Prrocessor = prrocessor;
            this.Memory = memory;
            this.GraphicCard = graphicCard;
            this.OS = oS;
            this.Photo = photo;
        }
        public string ExportCommonproduct_Data()
        {
            return $"{this.Type}:{this.ID}:{this.Brand}:{this.Model}:{this.Quantity}";
        }
        public string ExportUniqueproduct_Data()
        {
            return $"{this.ID}:{this.Type}:{this.Brand}:{this.Model}:Battery Capacity:{this.Battery}:Processor:{this.Prrocessor}:Laptop Memory:{this.Memory}:Graphic Card:{this.GraphicCard}:Operating System:{this.OS}:{this.Photo}";
        }
    }
}
