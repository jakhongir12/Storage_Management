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
    public partial class AddHeadPhoneForm : Form
    {
        public AddHeadPhoneForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddHeadPhone_Click(object sender, EventArgs e)
        {
            string type="Not-Wireless",NC="Not Noise-Cancelling";
            Headphone product = new Headphone("", "", "", "", "","");
            List<string> Items = new List<string>();
            string prd,photo="";
            int count = 0;
            if (HeadPhoneType_txt.Text != "")
            {
                product.HeadPhoneType = HeadPhoneType_txt.Text;
                if (HeadPhoneLoudness_txt.Text != "")
                {
                    product.Loiudness = HeadPhoneLoudness_txt.Text;
                    if (HeadPhoneColor_txt.Text != "")
                    {
                        product.Colour = HeadPhoneColor_txt.Text;
                            
                        if (headphone_wireless.Checked)
                        {
                            type = "Wireless";
                            product.Wireless = type;
                            if (headphone_noisecancelling.Checked)
                            {
                                NC = "Noise-Cancelling";
                                product.NoiseCanceling = NC;
                                product.Photo = "NOT STOCK";
                                photo = HeadPhonePictureBox.ImageLocation;
                                string[] temp = photo.Split('s');
                                if (temp[1] == @"\Headphone.png")
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
                                NC = "NOT Noise-Cancelling";
                                product.NoiseCanceling = NC;
                                product.Photo = "NOT STOCK";
                                photo = HeadPhonePictureBox.ImageLocation;
                                string[] temp = photo.Split('s');
                                if (temp[1] == @"\Headphone.png")
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
                        }
                        else
                        {
                            product.Wireless = type;
                            if (headphone_noisecancelling.Checked)
                            {
                                NC = "Noise-Cancelling";
                                product.NoiseCanceling = NC;
                                product.Photo = "NOT STOCK";
                                photo = HeadPhonePictureBox.ImageLocation;
                                string[] temp = photo.Split('s');
                                if (temp[1] == @"\Headphone.png")
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
                                NC = "NOT Noise-Cancelling";
                                product.NoiseCanceling = NC;
                                product.Photo = "NOT STOCK";
                                photo = HeadPhonePictureBox.ImageLocation;
                                string[] temp = photo.Split('s');
                                if (temp[1] == @"\Headphone.png")
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
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select Color");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Loudnes value");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Type");
            }
            MessageBox.Show("New Product Added.");
            HeadPhoneLoudness_txt.Text = "";
            HeadPhoneColor_txt.SelectedIndex = HeadPhoneType_txt.SelectedIndex = -1;
            headphone_wireless.Checked = false;
            headphone_noisecancelling.Checked = false;
            HeadPhonePictureBox.Load("images\\Headphone.png");
        }

        private void CancelHeadPhone_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm Addproducts = new AddProductForm();
            Addproducts.ShowDialog();
            this.Close();
        }

        private void AddHeadPhoneForm_Load(object sender, EventArgs e)
        {
            string imgpath = "images\\Headphone.png";
            HeadPhonePictureBox.Load(imgpath);
        }

        private void HeadPhoneLoadPhoto_Click(object sender, EventArgs e)
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
                HeadPhonePictureBox.Load(imgPath);
            }
        }
    }
}
