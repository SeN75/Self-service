using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework.Forms;


namespace WindowsFormsApplication1
{
    public partial class Arabic : MetroForm
    {


        public Arabic()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(400);
            MessageBox.Show("عفواً السيرفر مغلق حاليا الرجاء المحاولة في وقت لاحق", "عفوا", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            return;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;
            try
            {
                ServiceReference1.StudentServiceClient St = new ServiceReference1.StudentServiceClient();
                ServiceReference1.Student std = St.GetStudentWithLikleyName(textBox1.Text);
                MessageBox.Show(std.Name);

                if (DateTime.Now.Hour == 7)
                {
                    if (std.Place1.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (std.Place1.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (std.Place1.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                    if (string.IsNullOrWhiteSpace(std.Place1))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }

                }
                else if (DateTime.Now.Hour == 8 && DateTime.Now.Minute < 46)
                {
                    if (string.IsNullOrWhiteSpace(std.Place2))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (std.Place2.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (std.Place2.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (std.Place2.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }
                else if ((DateTime.Now.Hour == 8 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 9 && DateTime.Now.Minute < 31))
                {
                    if (string.IsNullOrWhiteSpace(std.Place3))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (std.Place3.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (std.Place3.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (std.Place3.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 9 && DateTime.Now.Minute > 55) || (DateTime.Now.Hour == 10 && DateTime.Now.Minute < 46))
                {
                    if (string.IsNullOrWhiteSpace(std.Place4))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");

                    }
                    if (std.Place4.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (std.Place4.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (std.Place4.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 10 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 11 && DateTime.Now.Minute < 30))
                {
                    if (string.IsNullOrWhiteSpace(std.Place5))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (std.Place5.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (std.Place5.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (std.Place5.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 11 && DateTime.Now.Minute > 30) || (DateTime.Now.Hour == 12 && DateTime.Now.Minute < 15))
                {
                    if (string.IsNullOrWhiteSpace(std.Place6))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (std.Place6.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (std.Place6.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (std.Place6.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 12 && DateTime.Now.Minute > 15) || (DateTime.Now.Hour == 1))
                {
                    if (string.IsNullOrWhiteSpace(std.Place7))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (std.Place7.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");

                    }
                    if (std.Place7.StartsWith("B"))
                    {

                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");

                    }
                    if (std.Place7.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }

                    ServiceReference1.StudentServiceClient c = new ServiceReference1.StudentServiceClient();

                    c.GetStudentWithLikleyName(label1.Text = Convert.ToString(textBox1));
                    c.GetStudentWithAccAsync(label2.Text = Convert.ToString(textBox2));



                    c.GetStudentWithLikleyName(label1.Text = Convert.ToString(textBox1));
                    c.GetStudentWithAccAsync(label2.Text = Convert.ToString(textBox2));




                }
                //ServiceReference1.StudentServiceClient Sttv = new ServiceReference1.StudentServiceClient();
                ServiceReference1.Student sttd = St.GetStudentWithLikleyName(textBox1.Text);

                students_Tabels s = new students_Tabels();

                students_Tabels.s1 = sttd.Subject1.ToString();
                students_Tabels.s2 = sttd.Subject2.ToString();
                students_Tabels.s3 = sttd.Subject3.ToString();
                students_Tabels.s4 = sttd.Subject4.ToString();
                students_Tabels.s5 = sttd.Subject5.ToString();
                students_Tabels.s6 = sttd.Subject6.ToString();
                students_Tabels.s7 = sttd.Subject7.ToString();
                students_Tabels.name = sttd.Name.ToString();
                students_Tabels.acc = sttd.AccNumber.ToString();
                students_Tabels n = new students_Tabels();
                n.ShowDialog();
                students_Tabels.deleteall();
                this.Hide();


            }
            catch (Exception)
            {
                MessageBox.Show("اسم الطالب ليس موجود في النظام");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 k = new Form6();
            Hide();
            k.ShowDialog();
            Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {

            button3.Width = Width / 2;
            label1.Left = Width / 2 - (label1.Width / 2);
            textBox1.Left = Width / 2 - (textBox1.Width / 2);
            linkLabel1.Left = Width / 2 - (linkLabel1.Width / 2);
            label2.Left = Width / 2 - (label2.Width / 2);
            textBox2.Left = Width / 2 - (textBox2.Width / 2);
            label3.Left = Width / 2 - (label3.Width / 2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(400);
            MessageBox.Show("عفواً السيرفر مغلق حاليا الرجاء المحاولة في وقت لاحق", "عفوا", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            return;
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                    return;
                ServiceReference1.StudentServiceClient St = new ServiceReference1.StudentServiceClient();
                ServiceReference1.Student DO = St.GetStudentWithAcc(textBox2.Text);
                MessageBox.Show(DO.Name);

                if (DateTime.Now.Hour == 7)
                {
                    if (DO.Place1.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (DO.Place1.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (DO.Place1.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                    if (string.IsNullOrWhiteSpace(DO.Place1))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }

                }
                else if (DateTime.Now.Hour == 8 && DateTime.Now.Minute < 46)
                {
                    if (string.IsNullOrWhiteSpace(DO.Place2))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (DO.Place2.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (DO.Place2.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (DO.Place2.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }
                else if ((DateTime.Now.Hour == 8 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 9 && DateTime.Now.Minute < 31))
                {
                    if (string.IsNullOrWhiteSpace(DO.Place3))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (DO.Place3.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (DO.Place3.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (DO.Place3.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 9 && DateTime.Now.Minute > 55) || (DateTime.Now.Hour == 10 && DateTime.Now.Minute < 46))
                {
                    if (string.IsNullOrWhiteSpace(DO.Place4))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");

                    }
                    if (DO.Place4.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (DO.Place4.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (DO.Place4.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 10 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 11 && DateTime.Now.Minute < 30))
                {
                    if (string.IsNullOrWhiteSpace(DO.Place5))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (DO.Place5.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (DO.Place5.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (DO.Place5.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 11 && DateTime.Now.Minute > 30) || (DateTime.Now.Hour == 12 && DateTime.Now.Minute < 15))
                {
                    if (string.IsNullOrWhiteSpace(DO.Place6))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (DO.Place6.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");
                    }
                    if (DO.Place6.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (DO.Place6.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }

                else if ((DateTime.Now.Hour == 12 && DateTime.Now.Minute > 15) || (DateTime.Now.Hour == 1))
                {
                    if (string.IsNullOrWhiteSpace(DO.Place7))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي");
                    }
                    if (DO.Place7.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني");

                    }
                    if (DO.Place7.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول");
                    }
                    if (DO.Place7.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني");
                    }
                }
                ServiceReference1.Student sttd = St.GetStudentWithAcc(textBox2.Text);
                students_Tabels.deleteall();
                students_Tabels.s1 = sttd.Subject1.ToString();
                students_Tabels.s2 = sttd.Subject2.ToString();
                students_Tabels.s3 = sttd.Subject3.ToString();
                students_Tabels.s4 = sttd.Subject4.ToString();
                students_Tabels.s5 = sttd.Subject5.ToString();
                students_Tabels.s6 = sttd.Subject6.ToString();
                students_Tabels.s7 = sttd.Subject7.ToString();
                students_Tabels.name = sttd.Name.ToString();
                students_Tabels.acc = sttd.AccNumber.ToString();
                students_Tabels baby = new students_Tabels();
                baby.ShowDialog();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("رقم الاكاديمي ليس موجود في النظام");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcesses().Where(p => p.ProcessName == "osk.exe").Count() > 0)
                return;
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcesses().Where(p => p.ProcessName == "osk.exe").Count() > 0)
                return;
            System.Diagnostics.Process.Start("osk.exe");
        }
    }
}