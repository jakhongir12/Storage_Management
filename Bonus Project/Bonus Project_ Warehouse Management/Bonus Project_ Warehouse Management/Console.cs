using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Project__Warehouse_Management
{
    internal class Console : Product
    {
        public override string Type { get; set; }
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override double Quantity { get; set; }
        public override string ID { get; set; }

        public string Storage, Controll, Ram, CPU, GPU, Photo;

        public Console (string storage, string controll, string ram, string cPU, string gPU, string photo)
        {
            this.Storage = storage;
            this.Controll = controll;
            this.Ram = ram;
            this.CPU = cPU;
            this.GPU = gPU;
            this.Photo = photo;
        }
        public string ExportCommonproduct_Data()
        {
            return $"{this.Type}:{this.ID}:{this.Brand}:{this.Model}:{this.Quantity}";
        }
        public string ExportUniqueproduct_Data()
        {
            return $"{this.ID}:{this.Type}:{this.Brand}:{this.Model}:Storage Capacity:{this.Storage}:Controller Version:{this.Controll}:RAM:{this.Ram}:CPU:{this.CPU}:GPU:{this.GPU}:{this.Photo}";
        }
    }
}
