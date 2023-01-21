using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonus_Project__Warehouse_Management
{
    public partial class AddLaptopForm : Form
    {
        public AddLaptopForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddLaptopForm_Load(object sender, EventArgs e)
        {
            string imgpath = "images\\Laptop.png";
            LaptopPictureBox.Load(imgpath);
        }

        private void AddLaptop_Click(object sender, EventArgs e)
        {           
            Laptop product = new Laptop("", "", "", "", "","");            
            List<string> Items = new List<string>();
            string prd,photo="";
            int count = 0;
            if ( LaptopBattery_txt.Text != "")
            {
                product.Battery = LaptopBattery_txt.Text;
                if (LaptopProcessor_txt.Text != "")
                {
                    product.Prrocessor = LaptopProcessor_txt.Text;
                    if (LaptopMemory_txt.Text != "")
                    {
                        product.Memory = LaptopMemory_txt.Text;
                        if (LaptopGraphicCatd_txt.Text != "")
                        {
                            product.GraphicCard = LaptopGraphicCatd_txt.Text;
                            if (LaptopOS_txt.Text != "")
                            {
                                product.OS = LaptopOS_txt.Text;
                                product.Photo = "NOT STOCK";
                                photo = LaptopPictureBox.ImageLocation;
                                string[] temp = photo.Split('s');
                                if (temp[1] == @"\Laptop.png")
                                {
                                    photo = "STOCK";
                                    product.Photo = photo;
                                }
                                FileStream nf = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
                                StreamReader ns = new StreamReader(nf);
                                while (!ns.EndOfStream)
                                {
                                    string s = ns.ReadLine();
                                    Items.Add(s);
                                    count++;
                                }
                                prd = Items[count - 1];
                                string[] data = prd.Split(':');                               
                                product.ID = data[1];
                                product.Type = data[0];
                                product.Brand = data[2];
                                product.Model = data[3];
                                FileStream fs = new FileStream("Unique.txt", FileMode.Append, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(fs);
                                sw.WriteLine(product.ExportUniqueproduct_Data());
                                ns.Close();
                                nf.Close();
                                sw.Close();
                                fs.Close();
                            }
                            else
                            {
                                MessageBox.Show("Please choose a OS");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Select a Graphic card");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Memory");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Processor");
                }
            }
            else
            {
                MessageBox.Show("Please select a Battery");
            }
            MessageBox.Show("New Product Added.");
            LaptopBattery_txt.Text = LaptopGraphicCatd_txt.Text = LaptopOS_txt.Text = "";
            LaptopProcessor_txt.SelectedIndex = LaptopMemory_txt.SelectedIndex = -1;
            LaptopPictureBox.Load("images\\Laptop.png");
        }

        private void CancelLaptop_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm Addproducts = new AddProductForm();
            Addproducts.ShowDialog();
            this.Close();
        }

        private void LaptopLoadPhoto_Click(object sender, EventArgs e)
        {
            FileStream nf = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            StreamReader ns = new StreamReader(nf);
            List<string> Items = new List<string>();
            int cnt = 0;
            string fname = "";
            while (!ns.EndOfStream)
            {
                Items.Add(ns.ReadLine());
                cnt++;
            }
            string prd = Items[cnt - 1];
            string[] data = prd.Split(':');
            fname = $"{data[1]}.png";
            nf.Close();
            ns.Close();
            ofd.Filter = "jpg Image | *.jpg|png Image|*.png|jpeg Image|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imgPath = ofd.FileName;               
                if (!Directory.Exists(@"./images"))
                {
                    Directory.CreateDirectory(@"./images");
                }
                File.Copy(imgPath, $"images\\{fname}", true);
                LaptopPictureBox.Load(imgPath);
            }
        }
    }
}
