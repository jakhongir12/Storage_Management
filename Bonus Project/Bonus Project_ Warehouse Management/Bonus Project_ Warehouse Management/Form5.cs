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
    public partial class TVFORM : Form
    {
        public TVFORM()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTV_Click(object sender, EventArgs e)
        {
            Tv product = new Tv("", "", "", "", "","");
            List<string> Items = new List<string>();
            string prd,photo="";
            int count = 0;
            if (TVSpeakers_txt.Text != "")
            {
                product.Speakers = TVSpeakers_txt.Text;
                if (TVDisplay_txt.Text != "")
                {
                    product.Display = TVDisplay_txt.Text;
                    if (YESNO.Text != "")
                    {
                        product.Voicesearch = YESNO.Text;
                        if (TVSize_txt.Text != "")
                        {
                            product.Size = TVSize_txt.Text;
                            if (TVOS_txt.Text != "")
                            {
                                product.OS = TVOS_txt.Text;
                                product.Photo = "NOT STOCK";
                                photo = TVPictureBox.ImageLocation;
                                string[] temp = photo.Split('s');
                                if (temp[1] == @"\TV.png")
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
                                MessageBox.Show("Please Enter a OS");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Size");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Value");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Diplay");
                }
            }
            else
            {
                MessageBox.Show("Please Enter speakers");
            }
            MessageBox.Show("New Product Added.");
            TVDisplay_txt.Text = TVSize_txt.Text = TVSpeakers_txt.Text = TVOS_txt.Text = "";
            YESNO.SelectedIndex = -1;
            TVPictureBox.Load("images\\TV.png");
        }

        private void CancelTV_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm Addproducts = new AddProductForm();
            Addproducts.ShowDialog();
            this.Close();
        }

        private void TVFORM_Load(object sender, EventArgs e)
        {
            string imgpath = "images\\TV.png";
            TVPictureBox.Load(imgpath);
        }

        private void TVLoadPhoto_Click(object sender, EventArgs e)
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
                TVPictureBox.Load(imgPath);
            }
        }
    }
}
