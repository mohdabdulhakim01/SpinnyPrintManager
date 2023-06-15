using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class posterprinter : Form
    {
        bool is_2x2 = true;
        Random r = new Random();
        
        string file_output = "";
       string temp_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\temp";
        
        public posterprinter()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileid = r.Next(0, 100000).ToString();
            file_output = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\temp\\poster_print_output" + fileid;
        
            OpenFileDialog selectFile = new OpenFileDialog();
            selectFile.Title = "Open Documents or Image Files";
            selectFile.Filter = "Image Files| *.jpg;*.jpeg;*.png;";
            selectFile.InitialDirectory = @"%userprofile%\pictures";
            selectFile.Multiselect = false;
            int dimen_2x2_image = 4;
            int dimen_3x3_image = 9;

            if (is_2x2)
            {

                if (selectFile.ShowDialog() == DialogResult.OK)
                {
                    string inputfile = selectFile.FileName;
                    
                    string split = "convert -crop 50%x50% \"" + inputfile + "\" \""+file_output+".jpg\"";
                    printmode_cmd(split);
                    // pg1_2x2

                    for (int x = 0; x < 4; x++)
                    {
                        // mogrify -shave 1x1 -bordercolor black -border 1 -format jpg *.jpg
                        string borderadd = "mogrify -shave 1x1 -bordercolor black -border 15 -format jpg \"" + file_output + "-" + x + ".jpg\"";
                        printmode_cmd(borderadd);
                    }
                    pg1_2x2.Image = Image.FromFile(file_output+"-0.jpg");
                     pg1_2x2.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg2_2x2.Image = Image.FromFile(file_output+"-1.jpg");
                    pg2_2x2.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg3_2x2.Image = Image.FromFile(file_output+"-2.jpg");
                    pg3_2x2.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg4_2x2.Image = Image.FromFile(file_output+"-3.jpg");
                    pg4_2x2.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
            else
            {
                if (selectFile.ShowDialog() == DialogResult.OK)
                {
                    string inputfile = selectFile.FileName;
                   
                    string split = "convert -crop 25%x25% \"" + inputfile + "\" \""+file_output+".jpg\"";
                    printmode_cmd(split);
                    // pg1_2x2
                    for (int x = 0; x < 16; x++)
                    {
                        // mogrify -shave 1x1 -bordercolor black -border 1 -format jpg *.jpg
                        string borderadd = "mogrify -shave 1x1 -bordercolor black -border 15 -format jpg \"" + file_output + "-" + x + ".jpg\"";
                        printmode_cmd(borderadd);
                    }
                    pg1_3x3.Image = Image.FromFile(file_output+"-0.jpg");
                    pg1_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg2_3x3.Image = Image.FromFile(file_output+"-1.jpg");
                    pg2_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg3_3x3.Image = Image.FromFile(file_output+"-2.jpg");
                    pg3_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg4_3x3.Image = Image.FromFile(file_output+"-3.jpg");
                    pg4_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg5_3x3.Image = Image.FromFile(file_output+"-4.jpg");
                    pg5_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg6_3x3.Image = Image.FromFile(file_output+"-5.jpg");
                    pg6_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg7_3x3.Image = Image.FromFile(file_output+"-6.jpg");
                    pg7_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg8_3x3.Image = Image.FromFile(file_output+"-7.jpg");
                    pg8_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg9_3x3.Image = Image.FromFile(file_output+"-8.jpg");
                    pg9_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg10_3x3.Image = Image.FromFile(file_output+"-9.jpg");
                    pg10_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg11_3x3.Image = Image.FromFile(file_output+"-10.jpg");
                    pg11_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg12_3x3.Image = Image.FromFile(file_output+"-11.jpg");
                    pg12_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg13_3x3.Image = Image.FromFile(file_output+"-12.jpg");
                    pg13_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg14_3x3.Image = Image.FromFile(file_output+"-13.jpg");
                    pg14_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg15_3x3.Image = Image.FromFile(file_output+"-14.jpg");
                    pg15_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                    pg16_3x3.Image = Image.FromFile(file_output+"-15.jpg");
                    pg16_3x3.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }

        }
        private void printmode_cmd(string command)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            //startInfo.RedirectStandardOutput = true;
            //startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = @"/c " + command;
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();
        }

       

        private void dimen_3x3_btn_CheckedChanged(object sender, EventArgs e)
        {
            is_2x2 = false;
           
            tile_3x3_frame.Visible = true;
            tile_2x2_frame.Visible = false;
        }

       
        private void posterprinter_Load(object sender, EventArgs e)
        {
            rad_2x2.Checked = true;
           
           
        }

        private void rad_2x2_CheckedChanged(object sender, EventArgs e)
        {
            is_2x2 = true;
            
           
            tile_3x3_frame.Visible = false;
            tile_2x2_frame.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (is_2x2)
            {
                for (int x = 0; x < 4; x++)
                {
                    string filename = file_output + "-" + x + ".jpg";
                    string printcommand = "sumatrapdf -print-to \"singlemode_print_hd\" \"" + filename + "\"";
                    printmode_cmd(printcommand);
                }
            }else{
                 
                for(int x = 0;x<16;x++){
                    string filename = file_output+"-"+x+".jpg";
                    string printcommand = "sumatrapdf -print-to \"singlemode_print_hd\" \""+filename+"\"";
                    printmode_cmd(printcommand);
                }
            }

        }

    }
}
