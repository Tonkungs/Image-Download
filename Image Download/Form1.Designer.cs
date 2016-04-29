namespace Image_Download
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pullimage = new System.Windows.Forms.Button();
            this.text_url_image = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgselect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.text_album_title = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.text_tag_other = new System.Windows.Forms.TextBox();
            this.text_anime_name = new System.Windows.Forms.TextBox();
            this.text_ch_name = new System.Windows.Forms.TextBox();
            this.text_cos_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnfolder_select = new System.Windows.Forms.Button();
            this.txtfolBD_output = new System.Windows.Forms.TextBox();
            this.imgcount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_dlimg = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folBD1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bgWork = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pullimage);
            this.groupBox1.Controls.Add(this.text_url_image);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imgselect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ลิงค์ที่การดาวโหลด";
            // 
            // btn_pullimage
            // 
            this.btn_pullimage.Location = new System.Drawing.Point(586, 19);
            this.btn_pullimage.Name = "btn_pullimage";
            this.btn_pullimage.Size = new System.Drawing.Size(75, 23);
            this.btn_pullimage.TabIndex = 4;
            this.btn_pullimage.Text = "ดึงรูปภาพ";
            this.btn_pullimage.UseVisualStyleBackColor = true;
            this.btn_pullimage.Click += new System.EventHandler(this.btn_pullimage_Click);
            // 
            // text_url_image
            // 
            this.text_url_image.Location = new System.Drawing.Point(300, 20);
            this.text_url_image.Name = "text_url_image";
            this.text_url_image.Size = new System.Drawing.Size(280, 20);
            this.text_url_image.TabIndex = 3;
            this.text_url_image.Text = "http://bcy.net/coser/detail/59243/536355";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ลิงค์ : ";
            // 
            // imgselect
            // 
            this.imgselect.FormattingEnabled = true;
            this.imgselect.Items.AddRange(new object[] {
            "Bcy.net",
            "Worldcosplay.net",
            "Instagram.com"});
            this.imgselect.Location = new System.Drawing.Point(109, 19);
            this.imgselect.Name = "imgselect";
            this.imgselect.Size = new System.Drawing.Size(149, 21);
            this.imgselect.TabIndex = 1;
            this.imgselect.SelectedIndexChanged += new System.EventHandler(this.imgselect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เว็บที่การดาวโหลด : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.text_album_title);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.text_tag_other);
            this.groupBox3.Controls.Add(this.text_anime_name);
            this.groupBox3.Controls.Add(this.text_ch_name);
            this.groupBox3.Controls.Add(this.text_cos_name);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลของลิงค์";
            // 
            // text_album_title
            // 
            this.text_album_title.Location = new System.Drawing.Point(138, 20);
            this.text_album_title.Name = "text_album_title";
            this.text_album_title.Size = new System.Drawing.Size(162, 20);
            this.text_album_title.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "ชื่ออัลบั้ม";
            // 
            // text_tag_other
            // 
            this.text_tag_other.Location = new System.Drawing.Point(138, 126);
            this.text_tag_other.Name = "text_tag_other";
            this.text_tag_other.Size = new System.Drawing.Size(162, 20);
            this.text_tag_other.TabIndex = 7;
            // 
            // text_anime_name
            // 
            this.text_anime_name.Location = new System.Drawing.Point(138, 99);
            this.text_anime_name.Name = "text_anime_name";
            this.text_anime_name.Size = new System.Drawing.Size(162, 20);
            this.text_anime_name.TabIndex = 6;
            // 
            // text_ch_name
            // 
            this.text_ch_name.Location = new System.Drawing.Point(138, 72);
            this.text_ch_name.Name = "text_ch_name";
            this.text_ch_name.Size = new System.Drawing.Size(162, 20);
            this.text_ch_name.TabIndex = 5;
            // 
            // text_cos_name
            // 
            this.text_cos_name.Location = new System.Drawing.Point(138, 46);
            this.text_cos_name.Name = "text_cos_name";
            this.text_cos_name.Size = new System.Drawing.Size(162, 20);
            this.text_cos_name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "แท็กต่าง ๆ ที่เกี่ยวข้อง : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "เรื่องที่เอามาคอส : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "คอสตัวละครชื่อ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "คนคอสชื่อ : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnfolder_select);
            this.groupBox4.Controls.Add(this.txtfolBD_output);
            this.groupBox4.Controls.Add(this.imgcount);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn_dlimg);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(340, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 156);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ข้อมูลเด็กเนิร์ด";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "150  kbp/s";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "0/10";
            // 
            // btnfolder_select
            // 
            this.btnfolder_select.Location = new System.Drawing.Point(299, 48);
            this.btnfolder_select.Name = "btnfolder_select";
            this.btnfolder_select.Size = new System.Drawing.Size(45, 23);
            this.btnfolder_select.TabIndex = 8;
            this.btnfolder_select.Text = "Folder";
            this.btnfolder_select.UseVisualStyleBackColor = true;
            this.btnfolder_select.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtfolBD_output
            // 
            this.txtfolBD_output.Location = new System.Drawing.Point(162, 49);
            this.txtfolBD_output.Name = "txtfolBD_output";
            this.txtfolBD_output.Size = new System.Drawing.Size(131, 20);
            this.txtfolBD_output.TabIndex = 7;
            this.txtfolBD_output.Text = "C:\\Cosplay\\Bcy\\\n\n\n缘之空 \n\\\n春日野穹 \\素爱";
            // 
            // imgcount
            // 
            this.imgcount.AutoSize = true;
            this.imgcount.Location = new System.Drawing.Point(165, 23);
            this.imgcount.Name = "imgcount";
            this.imgcount.Size = new System.Drawing.Size(13, 13);
            this.imgcount.TabIndex = 6;
            this.imgcount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "ความเร็ว : ";
            // 
            // btn_dlimg
            // 
            this.btn_dlimg.Location = new System.Drawing.Point(234, 112);
            this.btn_dlimg.Name = "btn_dlimg";
            this.btn_dlimg.Size = new System.Drawing.Size(108, 36);
            this.btn_dlimg.TabIndex = 3;
            this.btn_dlimg.Text = "ดาวโหลด";
            this.btn_dlimg.UseVisualStyleBackColor = true;
            this.btn_dlimg.Click += new System.EventHandler(this.btn_dlimg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "ดาวโหลดไฟล์ที่ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "บันทึกไฟล์ที่ : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "จำนวนรูปภาพทั้งหมดในลิงค์ : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 365);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(676, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // folBD1
            // 
            this.folBD1.Description = "เลือกที่บันทึกไฟล์";
            this.folBD1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folBD1.SelectedPath = "C:\\Cosplay\\Bcy";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 259);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(677, 95);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 417);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Image Download";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox imgselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pullimage;
        private System.Windows.Forms.TextBox text_url_image;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_tag_other;
        private System.Windows.Forms.TextBox text_anime_name;
        private System.Windows.Forms.TextBox text_ch_name;
        private System.Windows.Forms.TextBox text_cos_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnfolder_select;
        private System.Windows.Forms.TextBox txtfolBD_output;
        private System.Windows.Forms.Label imgcount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_dlimg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folBD1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_album_title;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker bgWork;
    }
}

