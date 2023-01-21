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
    public partial class SeeFullInformationForm : Form
    {
        public SeeFullInformationForm()
        {
            InitializeComponent();
        }

        private void SeeFullInformationForm_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("FullInfo.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> Items = new List<string>();
            string prd = "", imgpath = "";
            string id, type, brand, model, unq1, unq2, unq3, unq4, unq5,unqLabel1, unqLabel2, unqLabel3, unqLabel4, unqLabel5;
            id = type = brand = model = unq1 = unq2 = unq3 = unq4 = unq5 = unqLabel1 = unqLabel2= unqLabel3= unqLabel4= unqLabel5="";
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] data = s.Split(':');
                id = data[0];
                type = data[1];
                brand = data[2];
                model = data[3];
                unqLabel1 = data[4];
                unq1 = data[5];
                unqLabel2 = data[6];
                unq2 = data[7];
                unqLabel3 = data[8];
                unq3 = data[9];
                unqLabel4 = data[10];
                unq4 = data[11];
                unqLabel5 = data[12];
                unq5 = data[13];
            }
            FileStream pfs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
            StreamReader psr = new StreamReader(pfs);
            List<string> Items3 = new List<string>();
            while (!psr.EndOfStream)
            {
                string s = psr.ReadLine();
                string[] pic = s.Split(':');
                if (id == pic[0])
                {
                    Items3.Add(s);
                }
            }
            prd = Items3[0];
            string[] pic1 = prd.Split(':');
            imgpath = pic1[14];
            if (imgpath == "STOCK")
            {
                if (type == "Phone")
                {
                    AllProductsPictureBox.Load("images\\Phone.png");
                }
                else if (type == "Laptop")
                {
                    AllProductsPictureBox.Load("images\\Laptop.png");
                }
                else if (type == "Tv")
                {
                    AllProductsPictureBox.Load("images\\TV.png");
                }
                else if (type == "Headphones")
                {
                    AllProductsPictureBox.Load("images\\Headphone.png");
                }
                else if (type == "Console")
                {
                    AllProductsPictureBox.Load("images\\Conole.png");
                }
            }
            else if (imgpath == "NOT STOCK")
            {
                AllProductsPictureBox.Load($"images\\{id}.png");
            }
            psr.Close();
            pfs.Close();
            UnqData1.Text = $"{unqLabel1}:";
            UnqData2.Text = $"{unqLabel2}:";
            UnqData3.Text = $"{unqLabel3}:";
            UnqData4.Text = $"{unqLabel4}:";
            UnqData5.Text = $"{unqLabel5}:";
            ID_txt.Text = id;
            Type_txt.Text = type;
            Brand_txt.Text = brand;
            Model_txt.Text = model;
            Unq1_txt.Text = unq1;
            Unq2_txt.Text = unq2;
            Unq3_txt.Text = unq3;
            Unq4_txt.Text = unq4;
            Unq5_txt.Text = unq5;
            sr.Close();
            fs.Close();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelFullInformation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnqData5_Click(object sender, EventArgs e)
        {

        }
    }
}
