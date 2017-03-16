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
    public partial class students_Tabels : Form
    {
       public static  void deleteall() {
            s1 = null;
            s2 = null;
            s3 = null;
            s4 = null;
            s5 = null;
            s6 = null;
            s7 = null;
            acc = null;
            name = null;
        }
        public static string s1;
        public static string s2;
        public static string s3;
        public static string s4;
        public static string s5;
        public static string s6;
        public static string s7;
        public static string name;
        public static string acc;
        public students_Tabels()
        {
            InitializeComponent();
            label19.Text = s1;
            label18.Text = s2;
            label17.Text = s3;
            label16.Text = s4;
            label15.Text = s5;
            label14.Text = s6;
            label13.Text = s7;
            label1.Text = name;
            label12.Text = acc;

        }
        private void students_Tabels_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Resize(object sender, EventArgs e)
        {
            button1.Width = Width / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label19_Resize(object sender, EventArgs e)
        {
            label1.Left = Width / 2 - (label1.Width / 2);
            label2.Left = Width / 2 - (label2.Width / 2);
            label3.Left = Width / 2 - (label3.Width / 2);
            label11.Left = Width / 2 - (label11.Width / 2);
            label12.Left = Width / 2 - (label12.Width / 2);
            label13.Left = Width / 2 - (label13.Width / 2);
            label14.Left = Width / 2 - (label14.Width / 2);
            label15.Left = Width / 2 - (label15.Width / 2);
            label16.Left = Width / 2 - (label16.Width / 2);
            label17.Left = Width / 2 - (label17.Width / 2);
            label18.Left = Width / 2 - (label18.Width / 2);
            label19.Left = (Width / 2) - (label19.Width / 2);
          

        }

		private void label4_Click(object sender, EventArgs e)
		{

		}

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
