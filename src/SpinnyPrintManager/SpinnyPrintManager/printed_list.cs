using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class printed_list : Form
    {
        int total_files = 0;
        Double total_price = 0;
        int total_page = 0;
        List<string> id_list = new List<string>();
        List<string> username_list = new List<string>();
        List<string> date_list = new List<string>();
        List<string> filename_list = new List<string>();
        List<string> pagecount_list = new List<string>();
        List<string> filecount_list = new List<string>();
        List<string> dir_path_list = new List<string>();
        public printed_list()
        {
            InitializeComponent();
        }

        private void printed_list_Load(object sender, EventArgs e)
        {
            readprintedfiledata();
            summary();
        }
        void readprintedfiledata()
        {
            string[] lines = File.ReadAllLines("printed_list_report.txt");
            string currentid = "-";



            for (int x = 0;x<lines.Length ; x++)
            {
                //MessageBox.Show(lines[x]);
                //id,username,date,filename,pagecount
                string[] eachline = lines[x].Replace(",‎", "‎").Split('‎');//empty char
                if (eachline[0] == "")
                    continue;
                string userid = eachline[0];
                string username = eachline[1];
                string date = eachline[2];
                string filename = eachline[3];
                string dir_path = eachline[4];
                int pagecount = Int32.Parse(eachline[5]); ;
                //  MessageBox.Show("Current id "+currentid+" , ID"+id);




                if (currentid != userid)
                {

                    id_list.Add(userid);
                    username_list.Add(username);
                    date_list.Add(date);
                    filename_list.Add(filename);
                    pagecount_list.Add(pagecount.ToString());
                    filecount_list.Add("1");
                    dir_path_list.Add(dir_path);
                    currentid = userid;
                    continue;
                }
                if (currentid == userid)
                {
                    try
                    {

                       // MessageBox.Show(filename_list.Count().ToString());
                        int getindex = Int32.Parse(userid);
                        filename_list[getindex] = filename_list[getindex] + Environment.NewLine + filename;
                        pagecount_list[getindex] = (Int32.Parse(pagecount_list[getindex]) + Int32.Parse(eachline[5])).ToString();
                        filecount_list[getindex] = (Int32.Parse(filecount_list[getindex]) + 1).ToString();
                    }
                    catch (Exception e)
                    {
                    }

                }



            }
            dir_path_list.Reverse();
            for (int x = (id_list.Count - 1);x>=0 ; x--)
            {

                name.Items.Add(username_list[x]);
                date.Items.Add(date_list[x]);
                pagecount.Items.Add(Double.Parse(pagecount_list[x]));
                filecount.Items.Add(Double.Parse(filecount_list[x]));
                price.Items.Add("RM " + (Double.Parse(pagecount_list[x]) * 0.3).ToString("0.#0"));
                printfile.Items.Add(" Print File.");
            }
          
        }
        void summary()
        {
            string[] lines = File.ReadAllLines("printed_list_report.txt");
            total_files = 0;
            for (int x = 0; x < lines.Length; x++)
            {

                //id,username,date,filename,pagecount
                string[] eachline = lines[x].Replace(",‎", "‎").Split('‎');//empty char
                if (eachline[0] == "")
                    continue;
                string id = eachline[0];
                string username = eachline[1];
                string date = eachline[2];
                string filename = eachline[3];
                int pagecount = Int32.Parse(eachline[5]);
                total_page += pagecount;
                total_files++;

            }
           
            total_price = Double.Parse(total_page.ToString()) * 0.3;

            totalfile.Text = total_files.ToString();
            totalprice.Text = "RM "+total_price.ToString("0.#0");
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",dir_path_list[name.SelectedIndex]);
        }

        private void printfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.setinit_dir(dir_path_list[printfile.SelectedIndex]);
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("dd-MM-yyyy");
            string current_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string file_path = current_path + "\\" + "printed_list_report.txt";
            string newfilepath = current_path + "\\" + Path.GetFileNameWithoutExtension(file_path) + " - " +datetime + ".txt";
            File.Copy(file_path, newfilepath);
            File.WriteAllText(file_path, Environment.NewLine);
            MessageBox.Show("New Iteration Started !");
            this.Close();
            
        }
    }
}
