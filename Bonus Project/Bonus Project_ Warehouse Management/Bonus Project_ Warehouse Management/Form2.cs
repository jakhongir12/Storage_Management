using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bonus_Project__Warehouse_Management
{
    public partial class AddProductForm : Form
    {
        //enum weekday
        //{
        //    sunday,monday,tuesday
        //       
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm Menu = new MenuForm();
            Menu.ShowDialog();
            this.Close();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Temp_Product dict = new Temp_Product();
            string Model, Brand, Quantity, Type;
            double ID;
            Phone product = new Phone("", "", "", "", "","");
            
            int num = 0;
            string fl, ll, id;
            decimal temp = Quantity_txt.Value;
            double qty = Convert.ToDouble(temp);
            Quantity = Convert.ToString(qty);
            string chk = Type_txt.Text;
            int IDcheck = 0;
            if (Model_txt.Text != "")
            {
                Model = Model_txt.Text;
                product.Model = Model_txt.Text;
                if(qty!=0)
                {
                    product.Quantity = qty;
                    if(Brand_txt.Text!="")
                    {
                        Brand = Brand_txt.Text;
                        product.Brand = Brand_txt.Text;
                        if(Type_txt.Text != "")
                        {
                            Type = Type_txt.Text;
                            product.Type = Type_txt.Text;                                                       
                            fl = Brand_txt.Text.Substring(0, 3);
                            ll = Model_txt.Text.Substring(0, 3);
                            id = product.GenrateID(fl, ll);                            
                            IDcheck = product.CheckID(id);
                            while(IDcheck!=2)
                            {                                
                                fl = Brand_txt.Text.Substring(0, 3);
                                ll = Model_txt.Text.Substring(0, 3);
                                id = product.GenrateID(fl, ll);
                                IDcheck = product.CheckID(id);
                            }
                            product.ID = id;                         
                            FileStream fs = new FileStream("Common.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(product.ExportCommonproduct_Data());
                            sw.Close();
                            fs.Close();
                            if (chk == "Phone")
                            {
                                this.Hide();
                                AddPhoneForm add = new AddPhoneForm();
                                add.ShowDialog();
                                this.Close();
                            }
                            else if (chk == "Laptop")
                            {
                                this.Hide();
                                AddLaptopForm add = new AddLaptopForm();
                                add.ShowDialog();
                                this.Close();
                            }
                            else if (chk == "Tv")
                            {
                                this.Hide();
                                TVFORM add = new TVFORM();
                                add.ShowDialog();
                                this.Close();
                            }
                            else if (chk == "Headphones")
                            {
                                this.Hide();
                                AddHeadPhoneForm add = new AddHeadPhoneForm();
                                add.ShowDialog();
                                this.Close();
                            }
                            else if (chk == "Console")
                            {
                                this.Hide();
                                AddConsoleForm add = new AddConsoleForm();
                                add.ShowDialog();
                                this.Close();
                            }
                                                                                  
                        }
                        else
                        {
                            MessageBox.Show("Please choose a Type");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Brand");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Quantity");
                }
            }
            else
            {
                MessageBox.Show("Please select a Model");
            }  
        }
    }
}
