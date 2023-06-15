namespace WindowsFormsApplication1
{
    partial class print_monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print_monitor));
            this.filename = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.page_count = new System.Windows.Forms.TextBox();
            this.duplexmode = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.multi_print = new System.Windows.Forms.RadioButton();
            this.single_print = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.color2_radio = new System.Windows.Forms.RadioButton();
            this.color1_radio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.status_print_img = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resume_print = new System.Windows.Forms.Button();
            this.img_thumbnail = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_print_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(72, 239);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(168, 20);
            this.filename.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.page_count);
            this.groupBox1.Location = new System.Drawing.Point(272, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Page Range";
            // 
            // page_count
            // 
            this.page_count.Location = new System.Drawing.Point(6, 16);
            this.page_count.Name = "page_count";
            this.page_count.Size = new System.Drawing.Size(214, 20);
            this.page_count.TabIndex = 25;
            // 
            // duplexmode
            // 
            this.duplexmode.AutoSize = true;
            this.duplexmode.Location = new System.Drawing.Point(272, 197);
            this.duplexmode.Name = "duplexmode";
            this.duplexmode.Size = new System.Drawing.Size(89, 17);
            this.duplexmode.TabIndex = 24;
            this.duplexmode.Text = "Duplex Mode";
            this.duplexmode.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.multi_print);
            this.groupBox5.Controls.Add(this.single_print);
            this.groupBox5.Location = new System.Drawing.Point(272, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 67);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Print Type";
            // 
            // multi_print
            // 
            this.multi_print.AutoSize = true;
            this.multi_print.Location = new System.Drawing.Point(12, 42);
            this.multi_print.Name = "multi_print";
            this.multi_print.Size = new System.Drawing.Size(143, 17);
            this.multi_print.TabIndex = 6;
            this.multi_print.TabStop = true;
            this.multi_print.Text = "4 Pages dalam Sekeping";
            this.multi_print.UseVisualStyleBackColor = true;
            // 
            // single_print
            // 
            this.single_print.AutoSize = true;
            this.single_print.Location = new System.Drawing.Point(12, 19);
            this.single_print.Name = "single_print";
            this.single_print.Size = new System.Drawing.Size(100, 17);
            this.single_print.TabIndex = 5;
            this.single_print.TabStop = true;
            this.single_print.Text = "Single per Page";
            this.single_print.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.color2_radio);
            this.groupBox3.Controls.Add(this.color1_radio);
            this.groupBox3.Location = new System.Drawing.Point(272, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 52);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // color2_radio
            // 
            this.color2_radio.AutoSize = true;
            this.color2_radio.Location = new System.Drawing.Point(75, 19);
            this.color2_radio.Name = "color2_radio";
            this.color2_radio.Size = new System.Drawing.Size(90, 17);
            this.color2_radio.TabIndex = 1;
            this.color2_radio.TabStop = true;
            this.color2_radio.Text = "Hitam /  Putih";
            this.color2_radio.UseVisualStyleBackColor = true;
            // 
            // color1_radio
            // 
            this.color1_radio.AutoSize = true;
            this.color1_radio.Location = new System.Drawing.Point(12, 19);
            this.color1_radio.Name = "color1_radio";
            this.color1_radio.Size = new System.Drawing.Size(57, 17);
            this.color1_radio.TabIndex = 0;
            this.color1_radio.TabStop = true;
            this.color1_radio.Text = "Warna";
            this.color1_radio.UseVisualStyleBackColor = true;
            this.color1_radio.CheckedChanged += new System.EventHandler(this.color1_radio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.status_print_img);
            this.groupBox2.Location = new System.Drawing.Point(535, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 136);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // status_print_img
            // 
            this.status_print_img.Image = global::WindowsFormsApplication1.Properties.Resources.printer;
            this.status_print_img.Location = new System.Drawing.Point(7, 20);
            this.status_print_img.Name = "status_print_img";
            this.status_print_img.Size = new System.Drawing.Size(118, 110);
            this.status_print_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status_print_img.TabIndex = 0;
            this.status_print_img.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(519, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Berhenti print dan skip file ini";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resume_print
            // 
            this.resume_print.BackColor = System.Drawing.Color.Teal;
            this.resume_print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resume_print.Location = new System.Drawing.Point(395, 239);
            this.resume_print.Name = "resume_print";
            this.resume_print.Size = new System.Drawing.Size(111, 42);
            this.resume_print.TabIndex = 27;
            this.resume_print.Text = "Resume Print";
            this.resume_print.UseVisualStyleBackColor = false;
            this.resume_print.Click += new System.EventHandler(this.resume_print_Click);
            // 
            // img_thumbnail
            // 
            this.img_thumbnail.Location = new System.Drawing.Point(72, 12);
            this.img_thumbnail.Name = "img_thumbnail";
            this.img_thumbnail.Size = new System.Drawing.Size(168, 205);
            this.img_thumbnail.TabIndex = 0;
            this.img_thumbnail.TabStop = false;
            this.img_thumbnail.Click += new System.EventHandler(this.img_thumbnail_Click);
            // 
            // print_monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 294);
            this.Controls.Add(this.resume_print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.duplexmode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.img_thumbnail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "print_monitor";
            this.Text = "print_monitor";
            this.Load += new System.EventHandler(this.print_monitor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.status_print_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_thumbnail;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox duplexmode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton multi_print;
        private System.Windows.Forms.RadioButton single_print;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton color2_radio;
        private System.Windows.Forms.RadioButton color1_radio;
        private System.Windows.Forms.TextBox page_count;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox status_print_img;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resume_print;
    }
}