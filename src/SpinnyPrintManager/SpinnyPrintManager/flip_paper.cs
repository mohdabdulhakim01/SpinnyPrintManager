using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class flip_paper : Form
    {
        public flip_paper()
        {
            InitializeComponent();
        }

        int flip_confirm_count = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            flip_confirm_count--;
            if (flip_confirm_count < 0)
            {
                this.Close();
            }
            button1.Text = "Confirmation [ " + flip_confirm_count.ToString() + " ]";
        }

        private void flip_paper_Load(object sender, EventArgs e)
        {
            int start_loc = (int)Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Location = new Point(start_loc, Screen.PrimaryScreen.WorkingArea.Height/2);

            button1.Text = "Confirmation [ " + flip_confirm_count.ToString() + " ]";

        }
    }
}
