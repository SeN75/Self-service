using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.B1F2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Close();
		}

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 l = new Form7();
            Hide();
            l.ShowDialog();
			Show();

        }

		private void Form6_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
			
			
		}



	
		private void Form6_Resize(object sender, EventArgs e)
		{
			linkLabel1.Left = Width / 2 - (linkLabel1.Width / 2);
		}

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.B1F1;

        }

		private void button3_Click(object sender, EventArgs e)
		{

            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.B1F3;

        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
