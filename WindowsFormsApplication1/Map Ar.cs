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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Close();

               

        }

		private void Form7_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;

		}

		private void button2_Click(object sender, EventArgs e)
		{
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.B2F2;
            

        }

		private void button2_Resize(object sender, EventArgs e)
		{
			linkLabel1.Left = Width / 2 - (linkLabel1.Width / 2);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            /*Graphics a = pictureBox1.CreateGraphics();
           imageList1.Draw(a, new Point((pictureBox1.Width / 2), (pictureBox1.Height / 2)), );*/
           // Size aa = new Size(255, 255);

           // imageList1.ImageSize = aa;


           pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.B2F1;
        }

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{


		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
            
        }
	}
}
