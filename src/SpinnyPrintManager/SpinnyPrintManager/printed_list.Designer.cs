namespace WindowsFormsApplication1
{
    partial class printed_list
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
            this.name = new System.Windows.Forms.ListBox();
            this.date = new System.Windows.Forms.ListBox();
            this.price = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalprice = new System.Windows.Forms.Label();
            this.totalfile = new System.Windows.Forms.Label();
            this.pagecount = new System.Windows.Forms.ListBox();
            this.filecount = new System.Windows.Forms.ListBox();
            this.printfile = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(12, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(166, 394);
            this.name.TabIndex = 0;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.FormattingEnabled = true;
            this.date.Location = new System.Drawing.Point(167, 78);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(150, 394);
            this.date.TabIndex = 1;
            // 
            // price
            // 
            this.price.FormattingEnabled = true;
            this.price.Location = new System.Drawing.Point(520, 78);
            this.price.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(118, 394);
            this.price.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total File Printed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Price";
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice.Location = new System.Drawing.Point(137, 33);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(57, 20);
            this.totalprice.TabIndex = 6;
            this.totalprice.Text = "label4";
            // 
            // totalfile
            // 
            this.totalfile.AutoSize = true;
            this.totalfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfile.Location = new System.Drawing.Point(137, 9);
            this.totalfile.Name = "totalfile";
            this.totalfile.Size = new System.Drawing.Size(57, 20);
            this.totalfile.TabIndex = 7;
            this.totalfile.Text = "label5";
            this.totalfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pagecount
            // 
            this.pagecount.FormattingEnabled = true;
            this.pagecount.Location = new System.Drawing.Point(312, 78);
            this.pagecount.Name = "pagecount";
            this.pagecount.Size = new System.Drawing.Size(107, 394);
            this.pagecount.TabIndex = 8;
            // 
            // filecount
            // 
            this.filecount.FormattingEnabled = true;
            this.filecount.Location = new System.Drawing.Point(410, 78);
            this.filecount.Name = "filecount";
            this.filecount.Size = new System.Drawing.Size(112, 394);
            this.filecount.TabIndex = 9;
            // 
            // printfile
            // 
            this.printfile.FormattingEnabled = true;
            this.printfile.Location = new System.Drawing.Point(634, 78);
            this.printfile.Name = "printfile";
            this.printfile.Size = new System.Drawing.Size(118, 394);
            this.printfile.TabIndex = 10;
            this.printfile.SelectedIndexChanged += new System.EventHandler(this.printfile_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Page Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "File Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Option";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "New Day";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printed_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.printfile);
            this.Controls.Add(this.filecount);
            this.Controls.Add(this.pagecount);
            this.Controls.Add(this.totalfile);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Name = "printed_list";
            this.Text = "printed_list";
            this.Load += new System.EventHandler(this.printed_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox name;
        private System.Windows.Forms.ListBox date;
        private System.Windows.Forms.ListBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label totalfile;
        private System.Windows.Forms.ListBox pagecount;
        private System.Windows.Forms.ListBox filecount;
        private System.Windows.Forms.ListBox printfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}