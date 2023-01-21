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
    public partial class AddPhoneForm : Form
    {
        public AddPhoneForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Phone product = new Phone("", "", "", "", "","");
            List<string> Items = new List<string>();
            string prd,photo="";
            int count = 0;
            if (PhoneBattery_txt.Text != "")
            {
                product.Battery = PhoneBattery_txt.Text;
                if (PhoneStorage_txt.Text != "")
                {
                    product.Storage = PhoneStorage_txt.Text;
                    if (PhoneCamera_txt.Text != "")
                    {
                        product.Camera = PhoneCamera_txt.Text;
                        if (PhoneDisplay_txt.Text != "")
                        {
                            product.Display = PhoneDisplay_txt.Text;
                            if (PhoneRam_txt.Text !="")
                            {
                                product.Ram = PhoneRam_txt.Text;
                                product.Photo = "NOT STOCK";
                                photo = PhonePictureBox.ImageLocation; 
                                string[] temp=photo.Split('s');
                                if(temp[1]==@"\Phone.png")
                                {
                                    photo = "STOCK";
                                    product.Photo = photo;
                                }
                                FileStream nf = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
                                StreamReader ns = new StreamReader(nf);
                                while(!ns.EndOfStream)
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
                                MessageBox.Show("Please choose a Ram");
                            }
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Please choose a Display");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Camera");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Storage");
                }
            }
            else
            {
                MessageBox.Show("Please Write the Battery");
            }
            MessageBox.Show("New Product Added.");
            PhoneBattery_txt.Text = PhoneDisplay_txt.Text = PhoneCamera_txt.Text = "";
            PhoneStorage_txt.SelectedIndex = PhoneRam_txt.SelectedIndex = -1;
            PhonePictureBox.Load("images\\Phone.png");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string imgpath = "images\\Phone.png";
            PhonePictureBox.Load(imgpath);           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                PhonePictureBox.Load(imgPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm Addproducts = new AddProductForm();
            Addproducts.ShowDialog();
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
