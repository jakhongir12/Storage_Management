using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Project__Warehouse_Management
{
    class Tv : Product
    {
        public override string Type { get; set; }
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override double Quantity { get; set; }
        public override string ID { get; set; }

        public string Display, Speakers, Voicesearch, Size, OS, Photo;

        public Tv(string Display,string Speakers,string Voicesearch,string Size,string OS,string photo)
        {
          this.Display = Display;
          this.Speakers = Speakers;
          this.Voicesearch = Voicesearch;
          this.Size = Size;
          this.OS = OS;
          this.Photo = photo;
        }
        public string ExportCommonproduct_Data()
        {
            return $"{this.Type}:{this.ID}:{this.Brand}:{this.Model}:{this.Quantity}";
        }
        public string ExportUniqueproduct_Data()
        {
            return $"{this.ID}:{this.Type}:{this.Brand}:{this.Model}:Display Type:{this.Display}:Speakers:{this.Speakers}:Voice Search option:{this.Voicesearch}:TV Size:{this.Size}:TV Operating System:{this.OS}:{this.Photo}";
        }
    }
}
