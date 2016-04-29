using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HAP = HtmlAgilityPack; //แพ็กเก็ตเสริม
using System.IO;
using System.Text.RegularExpressions; //reg
using System.Threading;
using System.Net;
namespace Image_Download
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void clearurl()
        {
            //ลบข้อมูล url 
            listBox1.Items.Clear();
        }
        private void imgselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           folBD1.ShowDialog();
           txtfolBD_output.Text = @folBD1.SelectedPath; // เอาค่าพาทที่เลือกแล้วไปใส่ text
           //MessageBox.Show("คุณเลือก Path " +folBD1.SelectedPath, "Foloer Select");
           //label11.Text = listBox1.Items.Count.ToString();
            
        }

        private void btn_pullimage_Click(object sender, EventArgs e)
        {
            //text_cos_name.Text = url;
            //สร้างอ็อกเจค์ getHtml 

            //เช็คง่า list มีไหม ถ้าลบ url ก่อนแล้วค่อยทำใหม่
            if (listBox1.Items.Count > 0)
                clearurl();
            //ส่งค่า document ไป
            processHtml(text_url_image.Text);
           
        }
        private void processHtml(string urlbcy)
        {
            
            var getHtml = new HAP.HtmlWeb();
            //เอาอ็อกเจค ไปรับค่า html  เก็บใส่ตัวแปร document
            var document = getHtml.Load(urlbcy);
            // เซ็ตชื่ออัลบั้ม
            //ลักษณะการเข้าถึง html
            string bcy_cos_album = "//h1[@class=\"js-post-title\"]";
            //สั่งเริ่มการเข้าถึง tag ตามที่ต้องการ  SelectSingleNode  คือ ต้องการแท็กเดียว
            var access_bcy = document.DocumentNode.SelectSingleNode(bcy_cos_album);
            // สร้างตัวแปรเพื่อเข้า Attributes title
            //HAP.HtmlAttribute album = access_bcy.Attributes["title"];
            //เซ็ตชื่อตามที่เจอ 
            text_album_title.Text = access_bcy.InnerHtml;
            // จบ เซ็ตชื่ออัลบั้ม

            // เซ็ตชื่อคนคอส
            //ลักษณะการเข้าถึง html
            string bcy_cos_name = "//a[@class=\"_avatar _avatar--xl _avatar--user mb10\"]";
            //สั่งเริ่มการเข้าถึง tag ตามที่ต้องการ  SelectSingleNode  คือ ต้องการแท็กเดียว
            access_bcy = document.DocumentNode.SelectSingleNode(bcy_cos_name);
            // สร้างตัวแปรเพื่อเข้า Attributes title
            HAP.HtmlAttribute title = access_bcy.Attributes["title"];
            //เซ็ตชื่อตามที่เจอ 
            text_cos_name.Text = title.Value;
            // จบ เซ็ตชื่อ
            
            // เซ็ตชื่อคอสตัวอะไร
            //ลักษณะการเข้าถึง html
            string bcy_cos_ch_name = "//a[@class=\"text mr5\"]";
            //สั่งเริ่มการเข้าถึง tag ตามที่ต้องการ  SelectSingleNode  คือ ต้องการแท็กเดียว
            access_bcy = document.DocumentNode.SelectSingleNode(bcy_cos_ch_name);
            // สร้างตัวแปรเพื่อเข้า Attributes title
            //HAP.HtmlAttribute ch_name = access_bcy.Attributes["title"];
            //เซ็ตชื่อตามที่เจอ เข้า html
            text_ch_name.Text = access_bcy.InnerHtml;
            // จบเซ็ตชื่อคอสตัวอะไร

            // เซ็ตชื่อเรื่อง
            //ลักษณะการเข้าถึง html
            string bcy_cos_anime_name = "//a[@class=\"btn btn--base btn--tag-2 btn--base-border-radius-circle btn--work\"]";
            //สั่งเริ่มการเข้าถึง tag ตามที่ต้องการ  SelectSingleNode  คือ ต้องการแท็กเดียว
            access_bcy = document.DocumentNode.SelectSingleNode(bcy_cos_anime_name);
            // สร้างตัวแปรเพื่อเข้า Attributes title
            //HAP.HtmlAttribute ch_name = access_bcy.Attributes["title"];
            //เซ็ตชื่อตามที่เจอ  เอาข้อความใน html
            text_anime_name.Text = access_bcy.InnerText;
            // จบเซ็ตชื่อคอสตัวอะไร

            // เซ็ตชื่อแท็กเรื่อง
            //ลักษณะการเข้าถึง html
            string bcy_cos_tag = "//div[@class=\"post__detail-tag\"]";
            //สั่งเริ่มการเข้าถึง tag ตามที่ต้องการ  SelectSingleNode  คือ ต้องการแท็กเดียว
            access_bcy = document.DocumentNode.SelectSingleNode(bcy_cos_tag);
            // สร้างตัวแปรเพื่อเข้า Attributes title
            //HAP.HtmlAttribute ch_name = access_bcy.Attributes["title"];
            //เซ็ตชื่อตามที่เจอ  เอาข้อความใน html
            text_tag_other.Text = access_bcy.InnerText;
            // จบเซ็ตชื่อคอสตัวอะไร

            //รูปภาพ
            String bcycode = "//img[@class=\"detail_std detail_clickable\"]";
            var bcy = document.DocumentNode.SelectNodes(bcycode);
            int counter = 0;
            if (bcy != null)
            {
                foreach (var aTag in bcy)
                {
                    counter++;
                    //หาแท็ก  src
                    HAP.HtmlAttribute src = aTag.Attributes["src"];
                    //เก็บค่าลง listBox1  นับความยาว
                    //ตัด /w650 ออก
                    listBox1.Items.Add(src.Value.Replace("/w650", null));
                    //แปลงตัวเลขเป็นข้อความ
                    imgcount.Text = counter.ToString();
                    
                }
            }
            //จบ//รูปภาพ
            
            //ใส่พาท
            txtfolBD_output.Text = folBD1.SelectedPath+"\\"+ text_anime_name.Text.ToString() +
                                                       "\\"+ text_ch_name.Text.ToString()+
                                                       "\\"+ text_cos_name.Text.ToString();/**/
            //txtfolBD_output.Text = folBD1.SelectedPath.ToString()+"\\"+text_anime_name.Text.ToString();
        }

        private void btn_dlimg_Click(object sender, EventArgs e)
        {
            download_imgbcy();
        }
        private void download_imgbcy()
        {
            int i,loop= listBox1.Items.Count;
            //ลบค่าแปลกๆ ออกไป เตรียมการสร้างโฟรเดอร์
            string replacement = Regex.Replace(txtfolBD_output.Text, @"\t|\n|\r", "");
            create_dir(replacement);
            //จบลบค่าแปลกๆ ออกไป เตรียมการสร้างโฟรเดอร์
            for (i = 0; i < loop; i++)
            {
                    String url = listBox1.Items[i].ToString();
                    //ตัดเอาชื่อไฟล์
                    string[] words = url.Split('/');
                    string reword = null;
                    foreach (string word in words)
                    {
                        reword = word;
                    }
                    words = null;
                    //จบตัดเอาชื่อไฟล์
                    //ค่าตัวแปรใช้ทั้งฟรอม
                    // Create an instance of WebClient
                    WebClient client = new WebClient();
                    // Hookup DownloadFileCompleted Event
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    // Start the download and copy the file to c:\temp
                    client.DownloadFileAsync(new Uri(url), replacement + "\\" + reword);
                /*while (client.IsBusy)
                {
                    System.Threading.Thread.Sleep(1);
                }*/
            }
        }
        

        private void create_dir(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    //MessageBox.Show("มีโฟรเดอร์นี้แล้ว");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    //MessageBox.Show("สร้างโฟรเดอร์ได้แล้ว");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProgressChanged(object sender,DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("ดาวโหลดเสร็จแล้ว");

        }
    }
}
