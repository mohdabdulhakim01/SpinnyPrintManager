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
using System.Diagnostics;
using System.Management;
namespace WindowsFormsApplication1
{
    public partial class print_monitor : Form
    {
        string print_command = "";
        string print_command_2 = "";
        string print_info_filename = "";
        string print_info_thumbnail_path = "";
        string print_info_color_type = "";
        string print_info_print_type = "";
        string printer_driver = "";
        string print_info_page_range = "";
        bool print_completion_state = false;
        bool is_halt = false;
        public print_monitor()
        {
            InitializeComponent();
        }
        
        private void print_monitor_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Top = 0;
            //MessageBox.Show(print_info_thumbnail_path);
            img_thumbnail.Image = Image.FromFile(print_info_thumbnail_path);
            img_thumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            filename.Text = print_info_filename;
            page_count.Text = print_info_page_range;
            if (print_info_color_type == "color")
            {
                color1_radio.Checked = true;
                color2_radio.Checked = false;
            }
            else
            {
                color1_radio.Checked = false;
                color2_radio.Checked = true;
            }
            if (print_info_print_type == "duplex_off")
            {
                single_print.Checked = true;
                multi_print.Checked = false;
            }
            else
            {
                single_print.Checked = false;
                multi_print.Checked = true;
            }

            if (print_info_print_type == "duplex_off")
            {
                duplexmode.Checked = false;
                Task.Factory.StartNew(() => print_session_single());
            }
            else
            {
                duplexmode.Checked = true;
                Task.Factory.StartNew(() => print_session_duplex());
            }
        }
   

        public void set_printer_driver(string printer_driver_x)
        {
            printer_driver = printer_driver_x;
        }
        public void set_command(string args)
        {
            print_command = args;
        }
        public void set_info(string filename,string thumbnail_path,string page_range,string color_type,string print_type,string print_command_x)
        {
            print_info_filename = filename;
            print_info_thumbnail_path = thumbnail_path;
            print_info_color_type = color_type;
            print_info_print_type = print_type;
            print_command_2 = print_command_x;
            print_info_page_range = page_range;
        }
        public string printer_check(string printerName)
        {

            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printerName);
            string alldata = "";
            int status = 0;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject service in searcher.Get())
            {
                // printerName = "\n " + service.Properties["Name"].Value.ToString();
                status = (UInt16)service.Properties["PrinterStatus"].Value;

            }
           // MessageBox.Show(status.ToString());
            // printing = 4,idle  = 3,offline/stuck = 1
            if (status == 3)
                return "idle";
            if (status == 4)
                return "printing";
            if (status == 1)
                return "halt";
            return "";
        }
        /* prntJobID = Convert.ToInt32(jobName.Split(splitArr)[1]);
                    // If the Job Id equals the input job Id, then cancel the job.
                    if (prntJobID == printJobID)
                    {
                        // Performs a action similar to the cancel
                        // operation of windows print console
                        prntJob.Delete();
                        isActionPerformed = true;
                        break;
                    }
         * /
         */
        public void cancel_print()
        {
            string query = "SELECT * FROM Win32_PrintJob";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject service in searcher.Get())
            {
                // printerName = "\n " + service.Properties["Name"].Value.ToString();
                string printjob = service.Properties["Name"].Value.ToString();
                printjob = printjob.Split(',')[1];
                service.Delete();

            }
        }
        public void resume_printing()
        {
            string query = "SELECT * FROM Win32_PrintJob";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject service in searcher.Get())
            {
                // printerName = "\n " + service.Properties["Name"].Value.ToString();
                string printjob = service.Properties["Name"].Value.ToString();
                printjob = printjob.Split(',')[1];
                service.InvokeMethod("Resume", null);

            }
        }
        public void pause_print()
        {
            string query = "SELECT * FROM Win32_PrintJob";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject service in searcher.Get())
            {
                // printerName = "\n " + service.Properties["Name"].Value.ToString();
                string printjob = service.Properties["Name"].Value.ToString();
                printjob = printjob.Split(',')[1];
                service.InvokeMethod("Pause", null);

            }
        }
        public void pool_mon()
        {
            string print_status = printer_check(printer_driver);
            bool completion = false;
            bool tell_print_opt = false;// 
            is_halt = false;
            System.Threading.Thread.Sleep(1000);
            while (completion == false)
            {
              //  MessageBox.Show(print_status);

                System.Threading.Thread.Sleep(1000);
                print_status = printer_check(printer_driver);
              //  MessageBox.Show(print_status);
                if (print_status == "halt")
                {
                    // If the paper stuck then give option to stop current printing and pass to 
                    MessageBox.Show("Printer is stuck / out of paper");
                    resume_print.Invoke((MethodInvoker)delegate
                    {
                        resume_print.Enabled = false;
                    });
                    is_halt = true;
                    break;
                }
                if (print_status == "idle")
                {
                    completion = true;
                    break;
                }

                

            }
        }
        public void print_session_duplex()
        {
            
            
            // the pool should be idle by now. so idle will be end of completion.
            
            resume_print.Invoke((MethodInvoker)delegate
            {
                resume_print.Enabled = false;
            });


            printmode_cmd(print_command); // print first command 
            pool_mon();
            if (!is_halt) {
                flip_paper flpaper = new flip_paper();
                flpaper.ShowDialog();
                printmode_cmd(print_command_2); // print first command 2
                pool_mon();
                if (!is_halt)
                {
                    System.Threading.Thread.Sleep(1000);
                   // MessageBox.Show("Print Complete !");
                    print_completion_state = true;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Close();
                    });
                }
               
            }
           
        }

        public void print_session_single()
        {
            string print_status = printer_check(printer_driver);
             bool completion = false;
            bool tell_print_opt = false;// 
          // the pool should be idle by now. so idle will be end of completion.
            printmode_cmd(print_command);
            resume_print.Invoke((MethodInvoker)delegate
            {
                resume_print.Enabled = false;
            }); 
            System.Threading.Thread.Sleep(1000);
            bool is_halt = false;
           
            pool_mon();
           
            if (!is_halt)
            {

                print_completion_state = true;
                try
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Close();
                    });
                }
                catch (Exception e)
                {

                }
               
                
            }
            System.Threading.Thread.Sleep(1000);
           
        }
        public bool get_completion_state()
        {
            return print_completion_state;
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

        private void resume_print_Click(object sender, EventArgs e)
        {
            
            resume_print.Enabled = false;

        }

        private void color1_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => btnclick());
            System.Threading.Thread.Sleep(2000);
            this.Close();
        }
        private void btnclick()
        {

            cancel_print();
            print_completion_state = false;
            
        }

        private void img_thumbnail_Click(object sender, EventArgs e)
        {

        }

    }

}
