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
    public partial class AllProductsForm : Form
    {
        public AllProductsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeeFullInformation_Click(object sender, EventArgs e)
        {
            string id = "";
            id = ProductID_txt.Text;
            FileStream fs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream nf = new FileStream("FullInfo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns = new StreamWriter(nf);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();                
                string[] data = s.Split(':');
                if (id == data[0])
                {
                    ns.WriteLine(s);
                    ns.Close();
                    nf.Close();
                    SeeFullInformationForm FullInfo = new SeeFullInformationForm();
                    FullInfo.ShowDialog();
                    break;
                }
            }        
            sr.Close();
            fs.Close();
            ns.Close();
            nf.Close();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            Left.Enabled = true;
            int cnt, temp = 0,count=0;
            string imgpath = "";
            cnt = Convert.ToInt32(Count.Text);
            temp = cnt + 1;           
            FileStream fs = new FileStream("Display.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> Items = new List<string>();
            string prd,temp_prd;
            double totalcount = 0;            
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                Items.Add(s);
                totalcount++;
            }
            if (cnt == 1 && cnt==totalcount)
            {
                Left.Enabled = false;
            }
            if (cnt==totalcount)
            {
                MessageBox.Show("Thats all the products we have!");
                Right.Enabled = false;
            }             
            else
            {
                prd = Items[cnt];
                string[] data = prd.Split(':');
                ProductType_txt.Text = data[0];
                ProductID_txt.Text = data[1];
                ProductBrand_txt.Text = data[2];
                ProductModel_txt.Text = data[3];
                ProductQuantity_txt.Text = data[4];                
                Count.Text = Convert.ToString(temp);
                TotalCount.Text = Convert.ToString(totalcount);
                FileStream pfs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
                StreamReader psr = new StreamReader(pfs);
                string prd2 = "";
                List<string> Items2 = new List<string>();
                while (!psr.EndOfStream)
                {
                    string s = psr.ReadLine();
                    string[] pic = s.Split(':');
                    if(data[1]==pic[0])
                    {
                        Items2.Add(s);
                        count++;
                    }  
                }
                prd2 = Items2[0];
                string[] pic2 = prd2.Split(':');
                imgpath = pic2[14];
                if (imgpath != "STOCK")
                {
                    AllProductsPictureBox.Load($"images\\{data[1]}.png");
                }
                else 
                {
                    
                    if (data[0] == "Phone")
                    {
                        AllProductsPictureBox.Load("images\\Phone.png");
                    }
                    else if (data[0] == "Laptop")
                    {
                        AllProductsPictureBox.Load("images\\Laptop.png");
                    }
                    else if (data[0] == "Tv")
                    {
                        AllProductsPictureBox.Load("images\\TV.png");
                    }
                    else if (data[0] == "Headphones")
                    {
                        AllProductsPictureBox.Load("images\\Headphone.png");
                    }
                    else if (data[0] == "Console")
                    {
                        AllProductsPictureBox.Load("images\\Conole.png");
                    }
                }
                psr.Close();
                pfs.Close();
            }   
            
            sr.Close();
            fs.Close();
        }

        private void LoadAllProduct_Click(object sender, EventArgs e)
        {
            Right.Enabled = true;
            string imgpath = "";
            FileStream fs = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream nf = new FileStream("Display.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns = new StreamWriter(nf);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                ns.WriteLine(s);
            }
            sr.Close();
            fs.Close();
            ns.Close();
            nf.Close();
            FileStream fs2 = new FileStream("Display.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);
            List<string> Items = new List<string>();
            string prd;
            string type, id, brand, model, quantity;
            type = id = brand = model = quantity = "";
            double totalcount = 0,i;
            while(!sr2.EndOfStream)
            {
                string s = sr2.ReadLine();
                Items.Add(s);
                totalcount++;
            }
            prd = Items[0];
            string[] data = prd.Split(':');
            ProductType_txt.Text = data[0];
            ProductID_txt.Text = data[1];
            ProductBrand_txt.Text = data[2];
            ProductModel_txt.Text = data[3];
            ProductQuantity_txt.Text = data[4];
            Count.Text = "1";
            TotalCount.Text = Convert.ToString(totalcount);
            Left.Enabled = false;
            FileStream pfs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
            StreamReader psr = new StreamReader(pfs);
            List<string> Items2 = new List<string>();
            while (!psr.EndOfStream)
            {
                string s = psr.ReadLine();
                Items2.Add(s);
            }
            prd = Items2[0];
            string[] pic = prd.Split(':');
            imgpath = pic[14];
            if (imgpath == "STOCK")
            {
                if (data[0] == "Phone")
                {
                    AllProductsPictureBox.Load("images\\Phone.png");
                }
                else if (data[0] == "Laptop")
                {
                    AllProductsPictureBox.Load("images\\Laptop.png");
                }
                else if (data[0] == "Tv")
                {
                    AllProductsPictureBox.Load("images\\TV.png");
                }
                else if (data[0] == "Headphones")
                {
                    AllProductsPictureBox.Load("images\\Headphone.png");
                }
                else if (data[0] == "Console")
                {
                    AllProductsPictureBox.Load("images\\Conole.png");
                }
            }
            else if (imgpath == "NOT STOCK")
            {
                AllProductsPictureBox.Load($"images\\{data[1]}.png");
            }
            psr.Close();
            pfs.Close();
            sr2.Close();
            fs2.Close();
            Keyword_txt.Text = AllProductType_txt.Text = "";
            ByBrand.Checked = ByID.Checked = ByModel.Checked = false;
        }

        private void AllProductsForm_Load(object sender, EventArgs e)
        {
            Right.Enabled = true;
            string imgpath = "";
            int count = 0;
            FileStream fs = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream nf = new FileStream("Display.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns = new StreamWriter(nf);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                ns.WriteLine(s);
            }
            sr.Close();
            fs.Close();
            ns.Close();
            nf.Close();
            FileStream fs2 = new FileStream("Display.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);
            List<string> Items = new List<string>();
            string prd;
            string type, id, brand, model, quantity;
            type = id = brand = model = quantity = "";
            double totalcount = 0, i;
            while (!sr2.EndOfStream)
            {
                string s = sr2.ReadLine();
                Items.Add(s);
                totalcount++;
            }
            prd = Items[0];
            string[] data = prd.Split(':');
            ProductType_txt.Text = data[0];            
            ProductID_txt.Text = data[1];
            ProductBrand_txt.Text = data[2];
            ProductModel_txt.Text = data[3];
            ProductQuantity_txt.Text = data[4];
            Count.Text = "1";
            TotalCount.Text = Convert.ToString(totalcount);
            FileStream pfs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
            StreamReader psr = new StreamReader(pfs);
            List<string> Items2 = new List<string>();
            while (!psr.EndOfStream)
            {
                string s = psr.ReadLine();
                Items2.Add(s);                
            }
            prd = Items2[0];
            string[] pic = prd.Split(':');
            imgpath = pic[14];
            if (imgpath == "STOCK")
            {
                if (data[0] == "Phone")
                {
                    AllProductsPictureBox.Load("images\\Phone.png");
                }
                else if (data[0] == "Laptop")
                {
                    AllProductsPictureBox.Load("images\\Laptop.png");
                }
                else if (data[0] == "Tv")
                {
                    AllProductsPictureBox.Load("images\\TV.png");
                }
                else if (data[0] == "Headphones")
                {
                    AllProductsPictureBox.Load("images\\Headphone.png");
                }
                else if (data[0] == "Console")
                {
                    AllProductsPictureBox.Load("images\\Conole.png");
                }
            }
            else if (imgpath == "NOT STOCK")
            {
                AllProductsPictureBox.Load($"images\\{data[1]}.png");
            }
            psr.Close();
            pfs.Close();            
            sr2.Close();
            fs2.Close();
            Left.Enabled = false;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            Right.Enabled=true;
            FileStream fs = new FileStream("Display.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> Items = new List<string>();
            string prd,temp_prd,imgpath="";
            double totalcount = 0;
            int cnt, temp = 0,count=0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                Items.Add(s);
                totalcount++;
            }
            cnt = Convert.ToInt32(Count.Text);
            temp = cnt - 1;
            prd = Items[temp - 1];
            string[] data = prd.Split(':');
            ProductType_txt.Text = data[0];
            ProductID_txt.Text = data[1];
            ProductBrand_txt.Text = data[2];
            ProductModel_txt.Text = data[3];
            ProductQuantity_txt.Text = data[4];
            Count.Text = Convert.ToString(temp);
            TotalCount.Text = Convert.ToString(totalcount);
            FileStream pfs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
            StreamReader psr = new StreamReader(pfs);
            List<string> Items2 = new List<string>();
            while (!psr.EndOfStream)
            {
                string s = psr.ReadLine();
                Items2.Add(s);
                count++;
            }
            cnt = Convert.ToInt32(Count.Text);          
            prd = Items2[cnt - 1];
            string[] pic = prd.Split(':');
            imgpath = pic[14];            
            if (imgpath == "STOCK")
            {
                if (data[0] == "Phone")
                {
                    AllProductsPictureBox.Load("images\\Phone.png");
                }
                else if (data[0] == "Laptop")
                {
                    AllProductsPictureBox.Load("images\\Laptop.png");
                }
                else if (data[0] == "Tv")
                {
                    AllProductsPictureBox.Load("images\\TV.png");
                }
                else if (data[0] == "Headphones")
                {
                    AllProductsPictureBox.Load("images\\Headphone.png");
                }
                else if (data[0] == "Console")
                {
                    AllProductsPictureBox.Load("images\\Conole.png");
                }
            }
            else if (imgpath == "NOT STOCK")
            {
                AllProductsPictureBox.Load($"images\\{data[1]}.png");
            }
            psr.Close();
            pfs.Close();
            temp_prd = Items[0];
            string[] temp_data = temp_prd.Split(':');
            if (ProductID_txt.Text == temp_data[1])
            {
                Left.Enabled = false;
            }
            sr.Close();
            fs.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                Right.Enabled = true;
                string imgpath = "";
                FileStream fs4 = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr4 = new StreamReader(fs4);
                FileStream nf3 = new FileStream("Display.txt", FileMode.Create, FileAccess.Write);
                StreamWriter ns3 = new StreamWriter(nf3);
                while (!sr4.EndOfStream)
                {
                    string s = sr4.ReadLine();
                    ns3.WriteLine(s);
                }
                sr4.Close();
                fs4.Close();
                ns3.Close();
                nf3.Close();
                Temp_Product writedata = new Temp_Product();
                string keyword = "", type = "", prd;
                keyword = Keyword_txt.Text;
                type = AllProductType_txt.Text;
                double totalcount = 0;
                int i;
                FileStream tfs = new FileStream("Search.txt", FileMode.Create, FileAccess.Write);
                StreamWriter tsr = new StreamWriter(tfs);
                tsr.Close();
                tfs.Close();
                FileStream nf = new FileStream("Temp.txt", FileMode.Create, FileAccess.Write);
                StreamWriter ns = new StreamWriter(nf);
                FileStream fs = new FileStream("Display.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                List<string> Items = new List<string>();
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    Items.Add(s);
                    totalcount++;
                }
                for (i = 0; i < totalcount; i++)
                {
                    ns.WriteLine(Items[i]);
                    prd = Items[i];
                    string[] data = prd.Split(':');
                    if(AllProductType_txt.Text=="")
                    {
                        if (ByBrand.Checked == true)
                        {
                            if (keyword == data[2])
                            {
                                writedata.Brand = data[2];
                                writedata.ID = data[1];
                                writedata.Type = data[0];
                                writedata.Model = data[3];
                                writedata.Quantity = Convert.ToDouble(data[4]);
                                FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(FS);
                                sw.WriteLine(writedata.ExportSearchproduct_Data());
                                sw.Close();
                                FS.Close();
                            }

                        }
                        else if (ByModel.Checked == true)
                        {
                            if (keyword == data[3])
                            {
                                writedata.Brand = data[2];
                                writedata.ID = data[1];
                                writedata.Type = data[0];
                                writedata.Model = data[3];
                                writedata.Quantity = Convert.ToDouble(data[4]);
                                FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(FS);
                                sw.WriteLine(writedata.ExportSearchproduct_Data());
                                sw.Close();
                                FS.Close();
                            }
                        }
                        else if (ByID.Checked == true)
                        {
                            if (keyword == data[1])
                            {
                                writedata.Brand = data[2];
                                writedata.ID = data[1];
                                writedata.Type = data[0];
                                writedata.Model = data[3];
                                writedata.Quantity = Convert.ToDouble(data[4]);
                                FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(FS);
                                sw.WriteLine(writedata.ExportSearchproduct_Data());
                                sw.Close();
                                FS.Close();
                            }
                        }
                        else
                        {
                            if (keyword == data[2])
                            {
                                writedata.Brand = data[2];
                                writedata.ID = data[1];
                                writedata.Type = data[0];
                                writedata.Model = data[3];
                                writedata.Quantity = Convert.ToDouble(data[4]);
                                FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                StreamWriter sw = new StreamWriter(FS);
                                sw.WriteLine(writedata.ExportSearchproduct_Data());
                                sw.Close();
                                FS.Close();
                            }
                        }
                    }
                    else
                    {
                        if (ByBrand.Checked == true)
                        {
                            if (keyword == data[2])
                            {
                                if (type == data[0])
                                {
                                    writedata.Brand = data[2];
                                    writedata.ID = data[1];
                                    writedata.Type = data[0];
                                    writedata.Model = data[3];
                                    writedata.Quantity = Convert.ToDouble(data[4]);
                                    FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                    StreamWriter sw = new StreamWriter(FS);
                                    sw.WriteLine(writedata.ExportSearchproduct_Data());
                                    sw.Close();
                                    FS.Close();
                                }                                
                            }

                        }
                        else if (ByModel.Checked == true)
                        {
                            if (keyword == data[3])
                            {
                                if (type == data[0])
                                {
                                    writedata.Brand = data[2];
                                    writedata.ID = data[1];
                                    writedata.Type = data[0];
                                    writedata.Model = data[3];
                                    writedata.Quantity = Convert.ToDouble(data[4]);
                                    FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                    StreamWriter sw = new StreamWriter(FS);
                                    sw.WriteLine(writedata.ExportSearchproduct_Data());
                                    sw.Close();
                                    FS.Close();
                                }                                
                            }
                        }
                        else if (ByID.Checked == true)
                        {
                            if (keyword == data[1])
                            {
                                if (type == data[0])
                                {
                                    writedata.Brand = data[2];
                                    writedata.ID = data[1];
                                    writedata.Type = data[0];
                                    writedata.Model = data[3];
                                    writedata.Quantity = Convert.ToDouble(data[4]);
                                    FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                    StreamWriter sw = new StreamWriter(FS);
                                    sw.WriteLine(writedata.ExportSearchproduct_Data());
                                    sw.Close();
                                    FS.Close();
                                }                                
                            }
                        }
                        else
                        {
                            if (keyword == data[2])
                            {
                                if (type == data[0])
                                {
                                    writedata.Brand = data[2];
                                    writedata.ID = data[1];
                                    writedata.Type = data[0];
                                    writedata.Model = data[3];
                                    writedata.Quantity = Convert.ToDouble(data[4]);
                                    FileStream FS = new FileStream("Search.txt", FileMode.Append, FileAccess.Write);
                                    StreamWriter sw = new StreamWriter(FS);
                                    sw.WriteLine(writedata.ExportSearchproduct_Data());
                                    sw.Close();
                                    FS.Close();
                                }
                            }
                        }                       
                    }
                    
                }
                ns.Close();
                nf.Close();
                sr.Close();
                fs.Close();
                FileStream FS2 = new FileStream("Search.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(FS2);
                FileStream fs2 = new FileStream("Display.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw2 = new StreamWriter(fs2);
                while (!sr2.EndOfStream)
                {
                    string s = sr2.ReadLine();
                    sw2.WriteLine(s);
                }
                sr2.Close();
                FS2.Close();
                sw2.Close();
                fs2.Close();
                FileStream fs3 = new FileStream("Display.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr3 = new StreamReader(fs3);
                List<string> Items2 = new List<string>();
                string prd2;
                double totalcount2 = 0, j;
                while (!sr3.EndOfStream)
                {
                    string s = sr3.ReadLine();
                    Items2.Add(s);
                    totalcount2++;
                }
                prd2 = Items2[0];
                string[] data2 = prd2.Split(':');
                ProductType_txt.Text = data2[0];
                ProductID_txt.Text = data2[1];
                ProductBrand_txt.Text = data2[2];
                ProductModel_txt.Text = data2[3];
                ProductQuantity_txt.Text = data2[4];
                Count.Text = "1";
                TotalCount.Text = Convert.ToString(totalcount2);
                FileStream pfs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
                StreamReader psr = new StreamReader(pfs);
                List<string> Items3 = new List<string>();
                while (!psr.EndOfStream)
                {
                    string s = psr.ReadLine();
                    string[] pic = s.Split(':');
                    if (data2[1] == pic[0])
                    {
                        Items3.Add(s);
                    }
                }
                prd = Items3[0];
                string[] pic1 = prd.Split(':');
                imgpath = pic1[14];
                if (imgpath == "STOCK")
                {
                    if (data2[0] == "Phone")
                    {
                        AllProductsPictureBox.Load("images\\Phone.png");
                    }
                    else if (data2[0] == "Laptop")
                    {
                        AllProductsPictureBox.Load("images\\Laptop.png");
                    }
                    else if (data2[0] == "Tv")
                    {
                        AllProductsPictureBox.Load("images\\TV.png");
                    }
                    else if (data2[0] == "Headphones")
                    {
                        AllProductsPictureBox.Load("images\\Headphone.png");
                    }
                    else if (data2[0] == "Console")
                    {
                        AllProductsPictureBox.Load("images\\Conole.png");
                    }
                }
                else if (imgpath == "NOT STOCK")
                {
                    AllProductsPictureBox.Load($"images\\{data2[1]}.png");
                }
                psr.Close();
                pfs.Close();
                sr3.Close();
                fs3.Close();
                Left.Enabled = false;
            }
            
            catch(Exception f)
            {
                MessageBox.Show("The Entered  keyword is wrong or empty! Please try again");
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Keyword_txt.Text = AllProductType_txt.Text = "";
            ByBrand.Checked = ByID.Checked = ByModel.Checked = false;
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            FileStream nf = new FileStream("FullInfo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns = new StreamWriter(nf);
            string DeleteID = "",imgpath="";
            int count = 0;
            DeleteID = ProductID_txt.Text;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] data = s.Split(':');
                if (DeleteID == data[1])
                {
                    continue;
                }
                else
                {
                    ns.WriteLine(s);
                }
            }
            sr.Close();
            fs.Close();
            ns.Close();
            nf.Close();
            FileStream fs1 = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs1);
            FileStream nf1 = new FileStream("Temp.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns1 = new StreamWriter(nf1);
            while (!sr1.EndOfStream)
            {
                string s = sr1.ReadLine();
                string[] data = s.Split(':');
                if (DeleteID == data[0])
                {
                    continue;
                }
                else
                {
                    ns1.WriteLine(s);
                }
            }
            sr1.Close();
            fs1.Close();
            ns1.Close();
            nf1.Close();
            FileStream fs2 = new FileStream("Temp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);
            FileStream fs3 = new FileStream("FullInfo.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr3 = new StreamReader(fs3);
            FileStream nf2 = new FileStream("Common.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns2 = new StreamWriter(nf2);
            FileStream nf3 = new FileStream("Unique.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ns3 = new StreamWriter(nf3);
            while (!sr2.EndOfStream)
            {
                string s = sr2.ReadLine();
                ns3.WriteLine(s);
            }
            while (!sr3.EndOfStream)
            {
                string s = sr3.ReadLine();
                ns2.WriteLine(s);
            }
            sr2.Close();
            fs2.Close();
            sr3.Close();
            fs3.Close();
            ns2.Close();
            nf2.Close();
            ns3.Close();
            nf3.Close();
            MessageBox.Show("Item Deleted");
            Right.Enabled = true;
            FileStream NEWfs = new FileStream("Common.txt", FileMode.Open, FileAccess.Read);
            StreamReader NEWsr = new StreamReader(NEWfs);
            FileStream NEWf = new FileStream("Display.txt", FileMode.Create, FileAccess.Write);
            StreamWriter NEWs = new StreamWriter(NEWf);
            while (!NEWsr.EndOfStream)
            {
                string s = NEWsr.ReadLine();
                NEWs.WriteLine(s);
            }
            NEWsr.Close();
            NEWfs.Close();
            NEWs.Close();
            NEWf.Close();
            FileStream NEWfs2 = new FileStream("Display.txt", FileMode.Open, FileAccess.Read);
            StreamReader NEWsr2 = new StreamReader(NEWfs2);
            List<string> Items = new List<string>();
            string prd;
            double totalcount = 0;
            while (!NEWsr2.EndOfStream)
            {
                string s = NEWsr2.ReadLine();
                Items.Add(s);
                totalcount++;
            }
            if (totalcount == 0)
            {
                NEWsr2.Close();
                NEWfs2.Close();
                this.Hide();
                MessageBox.Show("There are no Items in your Warehouse!");
                MenuForm Allproducts = new MenuForm();
                Allproducts.ShowDialog();
                this.Close();
            }
            else
            {
                prd = Items[0];
                string[] data1 = prd.Split(':');
                ProductType_txt.Text = data1[0];
                ProductID_txt.Text = data1[1];
                ProductBrand_txt.Text = data1[2];
                ProductModel_txt.Text = data1[3];
                ProductQuantity_txt.Text = data1[4];
                Count.Text = "1";
                TotalCount.Text = Convert.ToString(totalcount);
                Left.Enabled = false;
                NEWsr2.Close();
                NEWfs2.Close();
                Keyword_txt.Text = AllProductType_txt.Text = "";
                ByBrand.Checked = ByID.Checked = ByModel.Checked = false;
                FileStream pfs = new FileStream("Unique.txt", FileMode.Open, FileAccess.Read);
                StreamReader psr = new StreamReader(pfs);
                List<string> Items3 = new List<string>();
                while (!psr.EndOfStream)
                {
                    string s = psr.ReadLine();
                    Items3.Add(s);
                }
                prd = Items3[0];
                string[] pic1 = prd.Split(':');
                imgpath = pic1[14];
                if (imgpath == "STOCK")
                {
                    if (data1[0] == "Phone")
                    {
                        AllProductsPictureBox.Load("images\\Phone.png");
                    }
                    else if (data1[0] == "Laptop")
                    {
                        AllProductsPictureBox.Load("images\\Laptop.png");
                    }
                    else if (data1[0] == "Tv")
                    {
                        AllProductsPictureBox.Load("images\\TV.png");
                    }
                    else if (data1[0] == "Headphones")
                    {
                        AllProductsPictureBox.Load("images\\Headphone.png");
                    }
                    else if (data1[0] == "Console")
                    {
                        AllProductsPictureBox.Load("images\\Conole.png");
                    }
                }
                else if (imgpath == "NOT STOCK")
                {
                    AllProductsPictureBox.Load($"images\\{data1[1]}.png");
                }
                psr.Close();
                pfs.Close();
            }
        }

        private void AllProductsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
