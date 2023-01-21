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
    public partial class AddConsoleForm : Form
    {
        public AddConsoleForm()
        {
            InitializeComponent();
        }

        private void AddConsole_Click(object sender, EventArgs e)
        {
            Console product = new Console("", "", "", "", "","");
            List<string> Items = new List<string>();
            string prd,photo="";
            int count = 0;
            if (ConsoleInternalStorage_txt.Text != "")
            {
                product.Storage = ConsoleInternalStorage_txt.Text;
                if (ConsoleController_txt.Text != "")
                {
                    product.Controll = ConsoleController_txt.Text;
                    if (ConsoleCPU_txt.Text != "")
                    {
                        product.CPU = ConsoleCPU_txt.Text;
                        if (ConsoleGPU_txt.Text != "")
                        {
                            product.GPU = ConsoleGPU_txt.Text;
                            if (ConsoleRAM_txt.Text != "")
                            {
                                product.Ram = ConsoleRAM_txt.Text;
                                product.Photo = "NOT STOCK";
                                photo = ConsolePictureBox.ImageLocation;
                                string[] temp = photo.Split('s');
                                if (temp[1] == @"\Conole.png")
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
                                MessageBox.Show("Please Select Ram");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Please Select GPU");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select a CPU");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Controller");
                }
            }
            else
            {
                MessageBox.Show("Please Select Storage");
            }
            MessageBox.Show("New Product Added.");
            ConsoleCPU_txt.SelectedIndex = ConsoleGPU_txt.SelectedIndex = ConsoleInternalStorage_txt.SelectedIndex = ConsoleRAM_txt.SelectedIndex = -1;
            ConsoleController_txt.Text = "";
            ConsolePictureBox.Load("images\\Conole.png");
        }   

        private void CancelConsole_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm Addproducts = new AddProductForm();
            Addproducts.ShowDialog();
            this.Close();
        }

        private void AddConsoleForm_Load(object sender, EventArgs e)
        {
            string imgpath = "images\\Conole.png";
            ConsolePictureBox.Load(imgpath);
        }

        private void ConsoleLoadPhoto_Click(object sender, EventArgs e)
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
                ConsolePictureBox.Load(imgPath);
            }
        }
    }
}
