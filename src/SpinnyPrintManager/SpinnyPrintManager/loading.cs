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
namespace WindowsFormsApplication1
{
    public partial class loading : Form
    {
        int loadingtime_load = 0;
        public loading()
        {
            InitializeComponent();
        }

        public void setload_time(int time){
            loadingtime_load = time;
        }
        private void loading_Load(object sender, EventArgs e)
        {
        //MessageBox.Show(loadingtime_load.ToString());
            this.CenterToScreen();
            this.BringToFront();
            this.ControlBox = false;
        Timer MyTimer = new Timer();
        MyTimer.Interval = loadingtime_load;
        MyTimer.Tick += new EventHandler(MyTimer_Tick);
        MyTimer.Start();
    }

    private void MyTimer_Tick(object sender, EventArgs e)
    {
        
        this.Close();
    }
      
       
    }
}
