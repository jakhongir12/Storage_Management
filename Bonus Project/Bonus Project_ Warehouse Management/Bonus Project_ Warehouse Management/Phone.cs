using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bonus_Project__Warehouse_Management
{
    class Phone : Product
    {

        enum checking
        {
            yes = 1,
            no =2
        }
        public override string Type { get; set; }
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override double Quantity { get; set; }
        public override string ID { get; set; }

        public string Battery, Storage, Ram, Display, Camera, Photo;
        
        public Phone(string battery, string storage, string ram, string display, string camera,string photo)
        {
            this.Battery = battery;
            this.Storage = storage;
            this.Ram = ram;
            this.Display = display;
            this.Camera = camera;
            this.Photo = photo;
        }
        public string ExportCommonproduct_Data()
        {
            return $"{this.Type}:{this.ID}:{this.Brand}:{this.Model}:{this.Quantity}";
        }
        public string ExportUniqueproduct_Data()
        {
            return $"{this.ID}:{this.Type}:{this.Brand}:{this.Model}:Battery Capacity:{this.Battery}:Storage Capacity:{this.Storage}:RAM:{this.Ram}:Display:{this.Display}:Camera:{this.Camera}:{this.Photo}";
        }
        public string GenrateID(string fl, string ll)
        {
            int num = 0;
            Random random_ID = new Random();
            num = random_ID.Next(1000, 10000);
            return $"{fl}_{num}_{ll}";
        }
        public int CheckID(string id)
        {
            FileStream fs = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string ID = "";
            int i = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] data = s.Split(':');
                ID = data[1];
                if(ID == id)
                {
                    fs.Close();
                    sr.Close();
                    return Convert.ToInt32(checking.yes);
                }                
                i++;
            }
            //sw.Close();
            fs.Close();
            sr.Close();
            return Convert.ToInt32(checking.no);
        }
    }
}
