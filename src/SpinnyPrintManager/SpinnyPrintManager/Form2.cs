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
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.Diagnostics;
using System.Timers;
using System.Threading;
using System.Management;



namespace WindowsFormsApplication1 {
    public partial class Form2: Form {
        string current_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        string[] img_ext = { ".png", ".jpg", ".jpeg" };
        string[] office_ext = { ".doc", ".docx", ".xls",".xlsx",".ppt",".pptx" };
        String collageCopies = "1";
        List < string > file_list = new List < string > ();
        List < string > copies_list = new List < string > ();
        List < string > page_range_list = new List < string > ();
        List < string > color_list = new List < string > ();
        List < string > print_type_list = new List < string > ();
        List < string > trimmed_filename = new List < string > ();
        List < string > thumbnail_file = new List < string > ();
        List < string > full_file_path = new List < string > ();
        List < string > duplex_mode_list = new List < string > ();
        List < string > collage_mode_list = new List < string > ();
        List<string> combine_picture_list = new List<string>();
        List<string> doctype_check_list = new List<string>();
        List<string> complete_printed_file = new List<string>();
        List<string> complete_printed_total_page = new List<string>();
        string initialdir = @"%userprofile%\downloads";
        int page_count_total_printed = 0;
        public bool collage_print = false;
        public static int loadtime = 0;
        public bool thumbnail_loaded = false;
        loading loadF = new loading();
        string newfolder = new Random().Next(1000, 9999999).ToString();
        public static int loadingtime() {

            return loadtime;
        }
        public Form2()

        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            // boot loading.cs
            this.CenterToScreen();
            browsefile();
           

        }
        public void setinit_dir(string dir)
        {
            initialdir = dir;
        }
        public string getpdfcount(string path) {
            PdfReader pdfReader = new PdfReader(path);
            int numberOfPages = pdfReader.NumberOfPages;
            return numberOfPages.ToString();

        }

        public void browsefile()
        {

            // copies_inp,page_range_inp,color1_radio,color2_radio,single_print,multi_print
            bool duplexmode_active = false;

            bool filecollected = false;
            while (filecollected == false)
            {
                // MessageBox.Show("Anda mesti pilih file PDF sebelum langkau ke seterusnya !");
                filecollected = getfilepdf();
            }
            int sum = -1;
            foreach (string filename in file_list)
            {
                // trim path location first !
                // set all to default value. page set from 1 to x ( end page ) 
                string trimmed_name = Path.GetFileName(filename);
                int pdfcount = 1;
             

                string movedpath = Environment.CurrentDirectory + "\\print-order-set\\" + newfolder;
                string full_moved_filepath = movedpath + "\\" + trimmed_name;
         
                System.IO.Directory.CreateDirectory(movedpath);
                File.Copy(filename, full_moved_filepath); 
                //MessageBox.Show(Path.GetExtension(filename));
                if (img_ext.ToList().Contains(Path.GetExtension(full_moved_filepath)))
                {
                    doctype_check_list.Add("image");
                    collage_mode_list.Add("collage_on");
                    
                }
               
                else
                {
                    doctype_check_list.Add("pdf");
                    pdfcount = Int32.Parse(getpdfcount(full_moved_filepath));
                    collage_mode_list.Add("collage_off");
                }

               
              //  MessageBox.Show(full_moved_filepath);
               
                
                copies_list.Add("1");
                page_range_list.Add("1 - " + pdfcount.ToString());
                color_list.Add("color");
                print_type_list.Add("single");
                trimmed_filename.Add(trimmed_name);
                full_file_path.Add(full_moved_filepath);
                
                // if page less than 20 ,dont show duplex button.

                duplex_mode_list.Add("duplex_off");
                



            }
            picturelist.LargeImageList = imageList1;
            picturelist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            picturelist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            for (int index = 0; index < file_list.Count; index++)
            {
                string filename = trimmed_filename[index];
                for (int x = 0; x < office_ext.Length; x++)
                {
                    if (filename.Contains(office_ext[x]))
                    {
                        filename = filename.Replace(".pdf", "");
                    }
                }
                picturelist.Items.Add(filename, index);
            }
            // set index 0 to option value
            try
            {
                copies_inp.Text = copies_list[0];
                page_range_inp.Text = page_range_list[0];
                color1_radio.Checked = true;
                single_print.Checked = true;
                combine_picture.Checked = true;
            }
            catch (Exception y) { }

        }
        
        public bool getfilepdf() {
            OpenFileDialog selectFile = new OpenFileDialog();
            selectFile.Title = "Open Documents or Image Files";
            selectFile.Filter = "Doc Files,PDF files or Image Files| *.pdf;*.jpg;*.jpeg;*.png;*.docx;*.doc;*.ppt;*.pptx;*.xls;*.xlsx";
            selectFile.InitialDirectory = initialdir;
            selectFile.Multiselect = true;

            if (selectFile.ShowDialog() == DialogResult.OK) {
                
                // convert -colorspace RGB -density 50 litmus.pdf[0] litmus.png
                
                 foreach (string file in selectFile.FileNames)
                {
                    if (office_ext.ToList().Contains(Path.GetExtension(file)))
                    {
                        loadtime = 4500 ;
                        loading loadx = new loading();
                        loadx.setload_time(loadtime);
                        // MessageBox.Show(loadtime.ToString());
                        Task.Factory.StartNew(() => loadx.ShowDialog());
                        string command = "call OfficeToPDF.exe \"" + file + "\" \"" + file + ".pdf\"";
                        //MessageBox.Show(command);
                        printmode_cmd(command);
                        Thread.Sleep(4000);
                        generate_thumbnail(file + ".pdf");
                        file_list.Add(file + ".pdf");
                    }
                    else
                    {
                        loadtime = 2000;
                        loading loadx = new loading();
                        loadx.setload_time(loadtime);
                        // MessageBox.Show(loadtime.ToString());
                        Task.Factory.StartNew(() => loadx.ShowDialog());
                        generate_thumbnail(file);
                        file_list.Add(file);
                    }
                    

                }
                try {
                 
                    loadthumbnail();

                    
                    this.CenterToScreen();
                    this.Activate();


                } catch (Exception e) {}
                return true;
            } else {
                return false;
            }
        }


        private void copies_inp_TextChanged(object sender, EventArgs e) {
            Task.Factory.StartNew(() => copiesinpcheck());
           
        }
        private void copiesinpcheck()
        {
            int current_index = 0;
            try
            {

                current_index = picturelist.FocusedItem.Index;
            }
            catch (Exception x) { }
            if (current_index > -1)
                copies_list[current_index] = copies_inp.Text;
        }

        private void page_range_inp_TextChanged(object sender, EventArgs e) {
            Task.Factory.StartNew(() => pagerangeinpchange());
        }
        private void pagerangeinpchange()
        {
            int current_index = 0;
            try
            {

                current_index = picturelist.FocusedItem.Index;
            }
            catch (Exception x) { }
            if (current_index > -1)
                page_range_list[current_index] = page_range_inp.Text;
        }

        private void color1_radio_CheckedChanged(object sender, EventArgs e) {
            Task.Factory.StartNew(() => radiochange1());
        }
        private void radiochange1()
        {
            int current_index = 0;
            try
            {

                current_index = picturelist.FocusedItem.Index;
                if (current_index > -1)
                {
                    color_list[current_index] = "color";


                }
            }
            catch (Exception x) { }


        }

        private void color2_radio_CheckedChanged(object sender, EventArgs e) {
          
            Task.Factory.StartNew(() => radiochange2());
          
        }
        private void radiochange2()
        {
            int current_index = 0;
            try
            {

                current_index = picturelist.FocusedItem.Index;
            }
            catch (Exception x) { }
            if (current_index > -1)
                color_list[current_index] = "black_white";
        }

        private void single_print_CheckedChanged(object sender, EventArgs e) {
            Task.Factory.StartNew(() => single_print_check());
         
        }
        private void single_print_check()
        {
            int current_index = 0;
            try
            {

                current_index = picturelist.FocusedItem.Index;
            }
            catch (Exception x) { }
            if (current_index > -1)
                print_type_list[current_index] = "single";
        }

        private void groupBox5_Enter(object sender, EventArgs e) {

        }

        private void multi_print_CheckedChanged(object sender, EventArgs e) {
            Task.Factory.StartNew(() => multiprintcheck());
        }
        private void multiprintcheck()
        {
            int current_index = 0;
            try
            {

                current_index = picturelist.FocusedItem.Index;
            }
            catch (Exception x) { }
            if (current_index > -1)
                print_type_list[current_index] = "multiple";
        }

        private void print_btn_Click(object sender, EventArgs e) {
            print_btn.Enabled = false;
            print_btn.BackColor = Color.MediumSpringGreen;
            Task.Factory.StartNew(() => printbtnclick());

        }
        private void printbtnclick()
        {
           
            //MessageBox.Show("Dokumen anda sedang dicetak, sila tunggu beberapa minit untuk siap mencetak . . .");


            print_normal_mode();
            report_printing_cost();
        }
        private void print_duplex_mode(int file_index) {
            
            // sumatrapdf -print-settings "1x,1-2,color" -print-to "singlemode_print" litmus.pdf

            // color,printtype,range,copies
            string command = "";

            string color = color_list[file_index]; // color black_white
            string print_type = print_type_list[file_index]; // single multiple
            string range = page_range_list[file_index]; // 1- 7
            string copies = copies_list[file_index]; // 10
            string print_driver = "";


            if (print_type == "single")
                print_driver = "singlemode_print";
            if (print_type == "multiple")
                print_driver = "multimode_print";

            if (color == "black_white")
                color = "monochrome";
            int pagecount = Int32.Parse(getpdfcount(full_file_path[file_index]));
            if (print_driver == "singlemode_print") {


                if (is_odd(pagecount)) { // if total of page is end with odd then print the last page ( basically first print page but reversed )  with empty pdf
                    string discard_print = "sumatrapdf.exe -print-settings \"monochrome\" -print-to \"" + print_driver + "\" \"" + current_path + "\\discard_duplex_last_odd.pdf\"";
                    printmode_cmd(discard_print); // print odd page first.then ask user to flip the printed document

                }

                string odd_print = "sumatrapdf.exe -print-settings \"" + copies + "x," + range + "," + color + ",even\" -print-to \"" + print_driver + "\" \"" + full_file_path[file_index] + "\"";
               
                string even_print = "sumatrapdf.exe -print-settings \"" + copies + "x," + range + "," + color + ",odd\" -print-to \"" + print_driver + "\" \"" + full_file_path[file_index] + "\"";
                
                print_monitor pm = new print_monitor();
                //MessageBox.Show("hshs");
                pm.set_printer_driver(print_driver);
                pm.set_command(odd_print);
                pm.set_info(trimmed_filename[file_index], thumbnail_file[file_index], range,color, duplex_mode_list[file_index], even_print);
                pm.ShowDialog();

                if (pm.get_completion_state() == true)
                {
                    int total_duplex = gettotalpage(range)/2;
                    total_duplex = ((int)(total_duplex + 0.5m)+1) * (Int32.Parse(copies));
                    page_count_total_printed += total_duplex;
                    complete_printed_file.Add(trimmed_filename[file_index]);
                    complete_printed_total_page.Add(total_duplex.ToString());

                }
            } else {
                //string convert_maindir = "C:\\Program Files\\ImageMagick-7.1.0-Q16";
                 string convert_maindir = "C:\\Program Files (x86)\\ImageMagick-7.1.0-Q16";
                /*
                  
                   * imagick convert pdf (x range) [ all only ] to image then merge image to 4x4 page [ index ].png . 
                   * then merge image into pdf. 
                   * then use singlemode duplex printmode
                   * 
                   * convert -density 80 pdf  -background white -alpha background -alpha off output.png
                   * montage output-0.png output-1.png output-2.png output-3.png -background white -geometry +2+2 combined-1.jpg
                   * convert *.jpg -resample 50 merged.pdf
                   */
                string filename = full_file_path[file_index];
                string[] range_modify = range.Split('-');
                string start_str = range_modify[0].ToString().Trim();
                string end_str = range_modify[1].ToString().Trim();
                int start_page = Int32.Parse(start_str) - 1;
                int end_page = Int32.Parse(end_str) - 1;

                range = start_page.ToString() + " - " + end_page.ToString();
                string full_file_path_basename = current_path + "\\temp\\output-" + Path.GetFileName(filename);
                string generate_pdf_page = "call \"convert.exe\" -density 100 \"" + filename + "[" + range + "]\" -background white -alpha background -alpha off \"" + full_file_path_basename + ".png\" ";
                string clean_old_merge = "del /F /Q \"" + current_path + "\\temp\\output-" + "*.mergeimg\"";
                printmode_cmd(clean_old_merge);
                

                int index_merged_page = 0;
                int totalprint_page = end_page - start_page;
                loadtime = (1000 * (totalprint_page));
                loading loady = new loading();
                loady.setload_time(loadtime);
                //MessageBox.Show(loadtime.ToString());
               Task.Factory.StartNew(() => loady.ShowDialog());
                
                duplex_multimode_cmd(generate_pdf_page);
                for (int x = start_page; x < end_page; x += 4) {
                    string merge_img = "call \"" + convert_maindir + "\\montage.exe\" \"" + full_file_path_basename + "-" + (x) + ".png\" \"" + full_file_path_basename + "-" + (x + 1) + ".png\" \"" + full_file_path_basename + "-" + (x + 2) + ".png\" \"" + full_file_path_basename + "-" + (x + 3) + ".png\" -background white -geometry +2+2 \"" + current_path + "\\temp\\combined-" + index_merged_page + ".mergeimg\"";
                    //printmode_cmd(merge_img);
                    duplex_multimode_cmd(merge_img);
                    index_merged_page++;
                }
                //System.Threading.Thread.Sleep(2000);
                string merge_to_pdf = "convert \"" + current_path + "\\temp\\*.mergeimg\" -resample 50 \"" + full_file_path_basename + "-complete.pdf\"";
               duplex_multimode_cmd(merge_to_pdf);

                string full_file_print_name = full_file_path_basename + "-complete.pdf";
                
                MessageBox.Show("Tekan [ OK ] untuk teruskan printing. . . !");
                int pagecount_ = Int32.Parse( getpdfcount(full_file_print_name));
                if (is_odd(pagecount_))
                { // if total of page is end with odd then print the last page ( basically first print page but reversed )  with empty pdf
                    string discard_print = "sumatrapdf.exe -print-settings \"monochrome\" -print-to \"" + print_driver + "\" \"" + current_path + "\\discard_duplex_last_odd.pdf\"";
                    printmode_cmd(discard_print); // print odd page first.then ask user to flip the printed document

                }
                print_driver = "singlemode_print";
                string even_print = "sumatrapdf.exe -print-settings \"" + copies + "x," + color + ",even\" -print-to \"" + print_driver + "\" \"" + full_file_print_name + "\"";
               string odd_print = "sumatrapdf.exe -print-settings \"" + copies + "x," + color + ",odd\" -print-to \"" + print_driver + "\" \"" + full_file_print_name + "\"";
                
                
                print_monitor pm = new print_monitor();
                pm.set_printer_driver(print_driver);
                pm.set_command(odd_print);
                pm.set_info(trimmed_filename[file_index], thumbnail_file[file_index],range, color, duplex_mode_list[file_index], even_print);
                pm.ShowDialog();


                if (pm.get_completion_state() == true)
                {
                    page_count_total_printed += (gettotalpage(range) * (Int32.Parse(copies)));
                    complete_printed_file.Add(trimmed_filename[file_index]);
                    complete_printed_total_page.Add((gettotalpage(range) * (Int32.Parse(copies))).ToString());

                }



            }
         //   MessageBox.Show("total page is : " + page_count_total_printed.ToString() + " ; RM " + (page_count_total_printed * 0.2));



        }
        private void duplex_multimode_cmd(string command) {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            //startInfo.RedirectStandardOutput = false;
            //startInfo.RedirectStandardError = false;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = @"/c " + command ;
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();

        }
        private void printmode_cmd(string command) {
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

        public void check_printer_status(string printerName)
        {
            
            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printerName);

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            using (ManagementObjectCollection coll = searcher.Get())
            {
                try
                {
                    foreach (ManagementObject printer in coll)
                    {
                        foreach (PropertyData property in printer.Properties)
                        {
                            
                        }
                    }
                }
                catch (ManagementException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public int gettotalpage(string range){
            string[] rawdata = range.Split(','); // count how many page specific print mode
            char[] separator = {'-'};
            int totalcontainsplit = 0;
            int totalpage = 0;
            int total_dash_page = 0;
            bool is_comma_exist = false;
            bool is_dash_exist = false;
            int specific_count_pg = 0;
            foreach(string data in rawdata){
                if(separator.All(data.Contains)){
                    string[] subseparated_data = data.Split('-');
                    total_dash_page += Int32.Parse(subseparated_data[1]) - Int32.Parse(subseparated_data[0])+1;
                    totalcontainsplit +=1;
                    is_dash_exist = true;
                   
                }
            }
            if (rawdata.Length > 0)
            {
                is_comma_exist = true;
            }

            if (is_comma_exist)
            {
                totalpage += rawdata.Length - totalcontainsplit;
            }
            if (is_dash_exist)
            {
                totalpage += total_dash_page;
            }
            if (!is_comma_exist && !is_dash_exist)
            {
                totalpage = 1;
            }

            //MessageBox.Show(totalpage.ToString());
            return totalpage;
        }
        public void report_printing_cost()
        {
            string[] lines = File.ReadAllLines("printed_list_report.txt");
            string[] eachline = lines[(lines.Length-1)].Replace(",‎", "‎").Split('‎');//empty char
            int id = -1;
            if (eachline[0] == "")
            {
                id = -1;
            }
            else
            {
                id = Int32.Parse(eachline[0]);
            }
            
            string current_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string report_data = "";
            string username = username_inp.Text;
            string datetime = DateTime.Now.ToString("hh:mm tt dd/MM/yyyy");
            if (username == "")
                username = "user-" + newfolder;
            string currentindex = (id+1).ToString();
            for(int x = 0;x<complete_printed_file.Count;x++)
            {
                // id,name,filename,pagecount,price
               // MessageBox.Show(complete_printed_file.Count.ToString());
                report_data += currentindex + ",‎" + username + ",‎" + datetime + ",‎" + complete_printed_file[x] + ",‎" + Path.GetDirectoryName(full_file_path[x]) + ",‎" + complete_printed_total_page[x] + Environment.NewLine;
            }
            
         
            Random r = new Random();
            int filename = r.Next(0, 100000);
            string file_path = current_path + "\\temp\\" + filename.ToString()+".txt";
            File.WriteAllText(file_path, report_data);
            string printcommand = "sumatrapdf -print-to \"singlemode_print\" \""+file_path+"\"";
            string printemptyseparator = "sumatrapdf -print-to \"singlemode_print\" \"discard_duplex_last_odd.pdf\"";
         
            using (StreamWriter w = File.AppendText("printed_list_report.txt"))
            {
                w.Write(report_data);
            }
            printmode_cmd(printemptyseparator);
        }

        private void print_normal_mode() {
            string current_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // sumatrapdf -print-settings "1x,1-2,color" -print-to "singlemode_print" litmus.pdf

            // color,printtype,range,copies
            string command = "";
            collage_print = false;
            Boolean first_collage_img = true;
            for (int x = 0; x < full_file_path.Count; x++) // loop all file
            {
               
                
                string color = color_list[x]; // color black_white
                string print_type = print_type_list[x]; // single multiple
                string range = page_range_list[x]; // 1- 7
                string copies = copies_list[x]; // 10
                string duplex_check = duplex_mode_list[x];
                string print_driver = "";

                if (print_type == "single")
                    print_driver = "singlemode_print";
                if (print_type == "multiple")
                    print_driver = "multimode_print";

                if (color == "black_white")
                    color = "monochrome";

                string file_ext = Path.GetExtension(full_file_path[x]);
                
               //MessageBox.Show(file_ext);
               if (doctype_check_list[x] == "image" && collage_mode_list[x] == "collage_on")
               {
                   if (first_collage_img)
                   {
                       collageCopies = copies_list[x];
                       first_collage_img = false;
                   }
                   // it's image. and use image printer.
                   // check if the image use collage mode, then add to list and report to the image printer
                   combine_picture_list.Add(full_file_path[x]);
                   //MessageBox.Show(full_file_path[x]);
                   collage_print = true;
               }
               else
               {
                   if (duplex_check == "duplex_on")
                   {
                       print_duplex_mode(x);
                   }
                   else // regular single print
                   {
                       if (doctype_check_list[x] == "image")
                           print_driver = "singlemode_print";
                       command = "sumatrapdf.exe -print-settings \"" + copies + "x," + range + "," + color + "\" -print-to \"" + print_driver + "\" \"" + full_file_path[x] + "\"";
                       //printmode_cmd(command);
                      // MessageBox.Show("here");
                       
                       print_monitor pm = new print_monitor();
                     pm.set_printer_driver(print_driver);
                      pm.set_command(command);
                      pm.set_info(trimmed_filename[x], thumbnail_file[x], range, color, duplex_mode_list[x], "");
                
                      pm.ShowDialog();
                       //pm.get_completion_state();

                      if (pm.get_completion_state() == true)
                       {
                           page_count_total_printed += (gettotalpage(range) * (Int32.Parse(copies)));
                           complete_printed_file.Add(trimmed_filename[x]);
                           complete_printed_total_page.Add((gettotalpage(range) * (Int32.Parse(copies))).ToString());
                           
                           
                       }
                   }
               }
            }// after finish printing other single item. check if collagemode active. if yes then proceed collage printing
            if (collage_print == true)
            {
                collage_printer();
            }


        }

        public void collage_printer()
        {
         
            /*
             * montage output-0.png output-1.png output-2.png output-3.png -background white -tile 3x3 combined-1.jpg
             * montage *.jpg *.png -tile 3x3 -geometry 300x300+5+5 -quality 90 -depth 5 combined.jpg
             */
            string image_list = "";
            
            foreach (string file in combine_picture_list)
            {
                image_list += "\"" + file + "\" ";
            }
            loading loady = new loading();
            loady.setload_time(combine_picture_list.Count*1000);

            Task.Factory.StartNew(() => loady.ShowDialog());
            Random r = new Random();
            int montage_id = r.Next(0, 100000);
            string full_image_path_dest = current_path + "\\temp\\output-" + Path.GetFileName(montage_id.ToString());
            string merge_image = "montage " + image_list + " -tile 3x3 -geometry 300x300+5+5 -quality 90 -depth 5 \"" + full_image_path_dest + ".jpg\"";
            printmode_cmd(merge_image);
           // MessageBox.Show(merge_image);
            int merged_total = combine_picture_list.Count / 9;
            int remainder = combine_picture_list.Count % 9;
            if(remainder>0){

                merged_total++;
            }

            string print_driver = "singlemode_print";
            string merge_thumbnail = full_image_path_dest + ".jpg";
            string merge_thumbnail_index = full_image_path_dest + "-0.jpg";
            string collage_thumbnail = "";
            string merge_files = "";
            string output_path = current_path + "\\temp\\output-" + montage_id + ".combined.pdf";
            //MessageBox.Show(merged_total.ToString());
            if (merged_total > 1)
            { // use index
              //  MessageBox.Show("here");
                collage_thumbnail = merge_thumbnail_index;
                for (int x = 0; x < merged_total; x++)
                {
                  merge_files +=  "\""+full_image_path_dest + "-"+x+".jpg\" ";
                
                }
                
                string command = "convert "+merge_files+" \""+output_path+"\" ";
               printmode_cmd(command);
               
            }
            else
            {
                collage_thumbnail = merge_thumbnail;
                merge_files = "\""+collage_thumbnail+"\"";
                string command = "convert " + merge_files + " \"" + output_path + "\"";
                printmode_cmd(command);
            }
            string trimmed_name = Path.GetFileName(output_path);
            string commandx = "call sumatrapdf.exe -print-settings \"color,"+collageCopies+"x\" -print-to \"singlemode_print\" \"" + output_path + "\"";
            //MessageBox.Show(collage_thumbnail);
            print_monitor pm = new print_monitor();
              int getpg_total_pdf = Int32.Parse( getpdfcount(output_path));
            
            pm.set_printer_driver("singlemode_print");
            pm.set_command(commandx);
            pm.set_info("Collage Print", collage_thumbnail, "1", "color", "duplex_off", "echo off");
          
            pm.ShowDialog();
            //pm.get_completion_state()

            if (pm.get_completion_state() == true)
            {
                page_count_total_printed += (getpg_total_pdf*Int32.Parse(collageCopies));
               // MessageBox.Show(page_count_total_printed.ToString());
                complete_printed_file.Add(trimmed_name);
                complete_printed_total_page.Add((getpg_total_pdf * Int32.Parse(collageCopies)).ToString());

            }
        
                
          

        }
        public void generate_thumbnail(string filename) {
            string current_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
           string convert_maindir = "C:\\Program Files (x86)\\ImageMagick-7.1.0-Q16";
            //string convert_maindir = "C:\\Program Files\\ImageMagick-7.1.0-Q16";
            // convert -density 70 litmus.pdf[0] -background white -alpha background -alpha off litmus.png
            string command = "call \"convert.exe\" -density 70 \"" + filename + "[0]\" -resize 300 -background white -alpha background -alpha off \"" + current_path + "\\temp\\" + Path.GetFileName(filename) + ".jpg\" ";
            //string commandx = "echo " + "call \"" + convert_maindir + "\\convert.exe\" -density 70 \"" + filename + "[0]\" -background white -alpha background -alpha off \"" + current_path + "\\temp\\" + Path.GetFileName(filename) + ".jpg\" ";
            thumbnail_file.Add(current_path + @"\temp\" + Path.GetFileName(filename) + ".jpg ");
                Process p = new Process(); ProcessStartInfo startInfo = new ProcessStartInfo();
                 startInfo.FileName = "cmd.exe"; startInfo.RedirectStandardOutput = false; startInfo.RedirectStandardError = true; startInfo.UseShellExecute = false; startInfo.CreateNoWindow = true; startInfo.Arguments = @"/c " + command; p.StartInfo = startInfo; p.Start(); p.WaitForExit();
            }

       public void loadthumbnail() {

                Graphics g = Graphics.FromHwnd(this.Handle);

                imageList1.TransparentColor = Color.Blue;
                imageList1.ColorDepth = ColorDepth.Depth32Bit;
                imageList1.ImageSize = new Size(100, 100);

                int sum = -1;
                foreach(string thumbnail in thumbnail_file) {
                    // MessageBox.Show(thumbnail);
                    Image img = new Bitmap(Image.FromFile(thumbnail));
                    SolidBrush blueBrush = new SolidBrush(Color.Red);
                    Rectangle rect = new Rectangle(0, 0, img.Width - 5, img.Height - 5);
                    Pen pen = new Pen(new SolidBrush(Color.Black));
                    pen.Width = 10;
                    using(Graphics x = Graphics.FromImage(img)) {
                        x.DrawImage(img, 0, 0, img.Width, img.Height);
                        x.DrawRectangle(pen, 0, 0, img.Width - 1, img.Height - 1);


                    }

                    // imageList1.Images.Add("1",Image.FromFile(thumbnail));
                    imageList1.Images.Add("1", img);
                }



                for (int count = 0; count < imageList1.Images.Count; count++) {

                    imageList1.Draw(g, new Point(20, 20), count);
                    Application.DoEvents();
                    // System.Threading.Thread.Sleep(100);

                }




            }

            private void preview_file_source() {
                int current_index = 0;
                try {

                    current_index = picturelist.FocusedItem.Index;
                } catch (Exception x) {}

                string filename = full_file_path[current_index];
                //MessageBox.Show(filename);
                string command = "call sumatrapdf.exe " + "\"" + filename + "\"";

                Process p = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;

                startInfo.Arguments = @"/c " + command;
                p.StartInfo = startInfo;
                p.Start();

            }

            private void set_file_option() {
                // if any index selection change. set right value based on list value setted
                int currentindex = picturelist.FocusedItem.Index;
                copies_inp.Text = copies_list[currentindex];
                page_range_inp.Text = page_range_list[currentindex];
                string filename = trimmed_filename[currentindex];
                 for (int x = 0; x < office_ext.Length; x++)
                {
                    if(filename.Contains(office_ext[x])){
                        filename = filename.Replace(".pdf", "");
                    }
                }
                 filename_disabled.Text = filename;

                if (color_list[currentindex] == "color") {
                    color1_radio.Checked = true;
                } else {
                    color2_radio.Checked = true;
                }

                if (print_type_list[currentindex] == "single") {
                    single_print.Checked = true;
                } else {
                    multi_print.Checked = true;
                }
                int pdfcount = 1; // default image
                if (doctype_check_list[currentindex] == "pdf")
                {
                    pdfcount = Int32.Parse(getpdfcount(full_file_path[currentindex]));
                }

                
                if (pdfcount < 4) {
                    duplexmode.Visible = false;
                } else {
                    duplexmode.Visible = true;
                }
                if (duplex_mode_list[currentindex] == "duplex_on") {
                    duplexmode.Checked = true;
                } else {
                    duplexmode.Checked = false;
                }
                if (doctype_check_list[currentindex] == "image") // if it image then set collage_on. 
                {
                    combine_picture.Visible = true;
                    if (collage_mode_list[currentindex] == "collage_on")
                    {
                       
                        combine_picture.Checked = true;
                    }
                    else
                    {
                        combine_picture.Checked = false;
                    }
                }
                else
                { // non image
                    combine_picture.Visible = false;
                }

            }
            private void picturelist_MouseDoubleClick(object sender, MouseEventArgs e) {
                preview_file_source();


            }

            private void picturelist_MouseClick(object sender, MouseEventArgs e) {
                set_file_option();

            }



            private bool is_odd(int n) {
                return n % 2 != 0;
            }



            private void enablePrintButtonToolStripMenuItem_Click_1(object sender, EventArgs e) {
                print_btn.Enabled = true;
                print_btn.BackColor = Color.LightSeaGreen;
            }

            private void duplexmode_CheckedChanged(object sender, EventArgs e) {
                int current_index = 0;
                try {

                    current_index = picturelist.FocusedItem.Index;
                } catch (Exception x) {}
                string duplex_state = "duplex_off";
                if (duplexmode.Checked == true) {
                    duplex_state = "duplex_on";

                } else {
                    duplex_state = "duplex_off";
                }
                duplex_mode_list[current_index] = duplex_state;
                //MessageBox.Show(duplex_state+ " - "+current_index);
            }

            private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
            {
                browsefile();
            }

            private void infoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                infodialog idialog = new infodialog();
                idialog.Show();
            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void combine_picture_CheckedChanged(object sender, EventArgs e)
            {
                
                int current_index = 0;
                try {

                    current_index = picturelist.FocusedItem.Index;
                } catch (Exception x) {}
                string collage_state = "collage_on";
                if (combine_picture.Checked == true) {
                    collage_state = "collage_on";

                } else {
                    collage_state = "collage_off";
                }
                collage_mode_list[current_index] = collage_state;
                //MessageBox.Show(duplex_state+ " - "+current_index);
            }

            private void printer_status_Click(object sender, EventArgs e)
            {
                string[] printer_device = { "singlemode_print", "singlemode_print", "multimode_print"};
                foreach (string printer in printer_device)
                {

                    check_printer_status(printer);
                }
            }

            private void Filename_Enter(object sender, EventArgs e)
            {

            }

            private void picturelist_SelectedIndexChanged(object sender, EventArgs e)
            {

            }



        }
    }