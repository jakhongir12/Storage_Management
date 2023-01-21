using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Project__Warehouse_Management
{
    internal class Headphone : Product
    {
        public override string Type { get; set; }
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override double Quantity { get; set; }
        public override string ID { get; set; }

        public string HeadPhoneType, Loiudness, Colour, Wireless, NoiseCanceling, Photo;

        public Headphone(string headPhoneType, string loiudness, string colour, string wireless, string noiseCanceling, string photo)
        {
            this.HeadPhoneType = headPhoneType;
            this.Loiudness = loiudness;
            this.Colour = colour;
            this.Wireless = wireless;
            this.NoiseCanceling = noiseCanceling;
            this.Photo = photo;
        }
        public string ExportCommonproduct_Data()
        {
            return $"{this.Type}:{this.ID}:{this.Brand}:{this.Model}:{this.Quantity}";
        }
        public string ExportUniqueproduct_Data()
        {
            return $"{this.ID}:{this.Type}:{this.Brand}:{this.Model}:Headphone Type:{this.HeadPhoneType}:Loudness:{this.Loiudness}:Headphone Color:{this.Colour}:Wireless:{this.Wireless}:Noise-Cancellation:{this.NoiseCanceling}:{this.Photo}";
        }
    }
}
