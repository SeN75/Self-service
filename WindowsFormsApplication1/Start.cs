using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApplication1
{
    public partial class Start : MetroForm
    {
		

		public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arabic F = new Arabic();
            Hide();
            F.ShowDialog();
			Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
           // English h = new English();
            Hide();
            //h.ShowDialog();
			Show();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			

			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			button1.Width = Width / 2;
			label1.Left = Width / 2 - (label1.Width / 2);
			label2.Left = Width / 2 - (label2.Width / 2);
			pictureBox1.Left = Width / 2 - (pictureBox1.Width / 2);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
