using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bonus_Project__Warehouse_Management
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs);
            //FileStream nf = new FileStream("Display.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter ns = new StreamWriter(nf);
            //double count = 0;
            //while (!sr.EndOfStream)
            //{
            //    //string s = sr.ReadLine();
            //    //ns.WriteLine(s);
            //    count++;
            //}
            //sr.Close();
            //fs.Close();
            //ns.Close();
            //nf.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {            
            FileStream fs = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream nf = new FileStream("Display.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns = new StreamWriter(nf);
            double count = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                ns.WriteLine(s);
                count++;
            }
            sr.Close();
            fs.Close();
            ns.Close();
            nf.Close();
            if (count==0)
            {
                MessageBox.Show("There are no Items in your Warehouse");
            }
            else {
                this.Hide();
                AllProductsForm AllProducts = new AllProductsForm();
                AllProducts.ShowDialog();
                this.Close();
            }            
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm Addproducts = new AddProductForm();
            Addproducts.ShowDialog();
            this.Close();
        }

        private void Exit_1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
