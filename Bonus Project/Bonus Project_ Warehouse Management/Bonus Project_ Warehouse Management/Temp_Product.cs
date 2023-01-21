using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Project__Warehouse_Management
{
    class Temp_Product:Product
    {
        public override string Type { get; set; }
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override double Quantity { get; set; }
        public override string ID { get; set; }

        public string ExportSearchproduct_Data()
        {
            return $"{this.Type}:{this.ID}:{this.Brand}:{this.Model}:{this.Quantity}";
        }






















        //    //Dictionary<string, Product> ProductList = new Dictionary<string, Product>() { get; }

        //    //public Dictionary<string, Product> ProductList { get; set; }











        //    public double count;

        //    public Dictionary<string, Phone> ProductList { get; set; }
        //    //public Dictionary<string, Tv> TvList { get; set; }
        //    //public Dictionary<string, Headphone> HeadphoneList { get; set; }
        //    //public Dictionary<string, Console> ConsoleList { get; set; }
        //    //public Dictionary<string, Laptop> LaptopList { get; set; }

        //    public Temp_Product()
        //    {
        //        ProductList = new Dictionary<string, Phone>();
        //        count = 0;
        //    }
        //    //public string checks(int id, Phone product)
        //    //{
        //    //    string ID = Convert.ToString(id);
        //    //    ProductList.Add(ID, product);
        //    //    foreach(var item in ProductList)
        //    //    {
        //    //        //return item;
        //    //    }
        //    //}
        //}
    }
}
