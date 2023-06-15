namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copies_inp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.color2_radio = new System.Windows.Forms.RadioButton();
            this.color1_radio = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.page_range_inp = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.multi_print = new System.Windows.Forms.RadioButton();
            this.single_print = new System.Windows.Forms.RadioButton();
            this.print_btn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enablePrintButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplexmode = new System.Windows.Forms.CheckBox();
            this.combine_picture = new System.Windows.Forms.CheckBox();
            this.picturelist = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.username_inp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.GroupBox();
            this.filename_disabled = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.Filename.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copies_inp);
            this.groupBox2.Location = new System.Drawing.Point(638, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Copies";
            // 
            // copies_inp
            // 
            this.copies_inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies_inp.Location = new System.Drawing.Point(6, 19);
            this.copies_inp.Name = "copies_inp";
            this.copies_inp.Size = new System.Drawing.Size(159, 22);
            this.copies_inp.TabIndex = 0;
            this.copies_inp.TextChanged += new System.EventHandler(this.copies_inp_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.color2_radio);
            this.groupBox3.Controls.Add(this.color1_radio);
            this.groupBox3.Location = new System.Drawing.Point(638, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 52);
            this.groupBox3.TabIndex = 1;
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
            this.color2_radio.CheckedChanged += new System.EventHandler(this.color2_radio_CheckedChanged);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.page_range_inp);
            this.groupBox4.Location = new System.Drawing.Point(638, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 63);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Page Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "e.g : 1 - 7 ";
            // 
            // page_range_inp
            // 
            this.page_range_inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_range_inp.Location = new System.Drawing.Point(6, 19);
            this.page_range_inp.Name = "page_range_inp";
            this.page_range_inp.Size = new System.Drawing.Size(159, 22);
            this.page_range_inp.TabIndex = 1;
            this.page_range_inp.TextChanged += new System.EventHandler(this.page_range_inp_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.multi_print);
            this.groupBox5.Controls.Add(this.single_print);
            this.groupBox5.Location = new System.Drawing.Point(638, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 67);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Print Type";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
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
            this.multi_print.CheckedChanged += new System.EventHandler(this.multi_print_CheckedChanged);
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
            this.single_print.CheckedChanged += new System.EventHandler(this.single_print_CheckedChanged);
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Location = new System.Drawing.Point(797, 381);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(145, 91);
            this.print_btn.TabIndex = 4;
            this.print_btn.Text = "Print All";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enablePrintButtonToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // enablePrintButtonToolStripMenuItem
            // 
            this.enablePrintButtonToolStripMenuItem.Name = "enablePrintButtonToolStripMenuItem";
            this.enablePrintButtonToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.enablePrintButtonToolStripMenuItem.Text = "Enable Print Button";
            this.enablePrintButtonToolStripMenuItem.Click += new System.EventHandler(this.enablePrintButtonToolStripMenuItem_Click_1);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.infoToolStripMenuItem.Text = "Help";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // duplexmode
            // 
            this.duplexmode.AutoSize = true;
            this.duplexmode.Location = new System.Drawing.Point(638, 312);
            this.duplexmode.Name = "duplexmode";
            this.duplexmode.Size = new System.Drawing.Size(89, 17);
            this.duplexmode.TabIndex = 21;
            this.duplexmode.Text = "Duplex Mode";
            this.duplexmode.UseVisualStyleBackColor = true;
            this.duplexmode.CheckedChanged += new System.EventHandler(this.duplexmode_CheckedChanged);
            // 
            // combine_picture
            // 
            this.combine_picture.AutoSize = true;
            this.combine_picture.Location = new System.Drawing.Point(638, 289);
            this.combine_picture.Name = "combine_picture";
            this.combine_picture.Size = new System.Drawing.Size(144, 17);
            this.combine_picture.TabIndex = 22;
            this.combine_picture.Text = "Gabung gambar jadi satu";
            this.combine_picture.UseVisualStyleBackColor = true;
            this.combine_picture.CheckedChanged += new System.EventHandler(this.combine_picture_CheckedChanged);
            // 
            // picturelist
            // 
            this.picturelist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picturelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picturelist.LargeImageList = this.imageList1;
            this.picturelist.Location = new System.Drawing.Point(14, 19);
            this.picturelist.Name = "picturelist";
            this.picturelist.Size = new System.Drawing.Size(578, 283);
            this.picturelist.TabIndex = 17;
            this.picturelist.UseCompatibleStateImageBehavior = false;
            this.picturelist.SelectedIndexChanged += new System.EventHandler(this.picturelist_SelectedIndexChanged);
            this.picturelist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturelist_MouseClick);
            this.picturelist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picturelist_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picturelist);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 312);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.username_inp);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(12, 366);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(770, 49);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Username";
            // 
            // username_inp
            // 
            this.username_inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_inp.Location = new System.Drawing.Point(6, 19);
            this.username_inp.Name = "username_inp";
            this.username_inp.Size = new System.Drawing.Size(758, 22);
            this.username_inp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 0;
            // 
            // Filename
            // 
            this.Filename.Controls.Add(this.filename_disabled);
            this.Filename.Location = new System.Drawing.Point(12, 421);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(770, 52);
            this.Filename.TabIndex = 23;
            this.Filename.TabStop = false;
            this.Filename.Text = "Filename";
            // 
            // filename_disabled
            // 
            this.filename_disabled.AutoSize = true;
            this.filename_disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_disabled.Location = new System.Drawing.Point(11, 16);
            this.filename_disabled.Name = "filename_disabled";
            this.filename_disabled.Size = new System.Drawing.Size(0, 18);
            this.filename_disabled.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(956, 484);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.combine_picture);
            this.Controls.Add(this.duplexmode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Filename.ResumeLayout(false);
            this.Filename.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.TextBox copies_inp;
        private System.Windows.Forms.RadioButton color2_radio;
        private System.Windows.Forms.RadioButton color1_radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox page_range_inp;
        private System.Windows.Forms.RadioButton multi_print;
        private System.Windows.Forms.RadioButton single_print;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enablePrintButtonToolStripMenuItem;
        private System.Windows.Forms.CheckBox duplexmode;
        private System.Windows.Forms.CheckBox combine_picture;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ListView picturelist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox username_inp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Filename;
        private System.Windows.Forms.Label filename_disabled;
    }
}