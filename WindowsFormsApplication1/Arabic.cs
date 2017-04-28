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
            var studnet1 = new
            {
                name = "شادي عصام عزت المصري",
                age = 12,
                class1 = "كيمياء3",
                place1 = "C1",
                class2 = "رياضيات4",
                place2 = "B2",
                class3 = "أحياء3",
                place3 = "B3",
                class4 = "فيزياء3",
                place4 = "A2",
                class5 = "إنجليزي4",
                place5 = "B1",
                class6 = "علم بيئة",
                place6 = "A12",
                class7 = "تربية مهنية",
                place7 = "C5"
            };
            var studnet2 = new
            {
                name = "أسامة محمد زكي هلال",
                age = 12,
                class1 = "كيمياء3",
                place1 = "C1",
                class2 = "رياضيات4",
                place2 = "B2",
                class3 = "أحياء3",
                place3 = "B3",
                class4 = "فيزياء3",
                place4 = "A2",
                class5 = "إنجليزي4",
                place5 = "B1",
                class6 = "علم بيئة",
                place6 = "A12",
                class7 = "تربية مهنية",
                place7 = "C5"
            };
            var studnet3 = new
            {
                name = "عبد العزيز عبد اللطيف المزين",
                age = 12,
                class1 = "كيمياء3",
                place1 = "C1",
                class2 = "رياضيات4",
                place2 = "B2",
                class3 = "أحياء3",
                place3 = "B3",
                class4 = "فيزياء3",
                place4 = "A2",
                class5 = "إنجليزي4",
                place5 = "B1",
                class6 = "علم بيئة",
                place6 = "A12",
                class7 = "تربية مهنية",
                place7 = "C5"
            };
            if (string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
                return;
            Random R = new Random();
            int number = R.Next(0, 2);
            var selectedStu = studnet1;
            switch (number)
            {
                case 0:
                    break;
                case 1:
                    selectedStu = studnet2;
                    break;
                case 2:
                    selectedStu = studnet3;
                    break;
            }
            ServiceReference1.Student stu = new ServiceReference1.Student();
            stu.Subject1 = selectedStu.class1;
            stu.Subject2 = selectedStu.class2;
            stu.Subject3 = selectedStu.class3;
            stu.Subject4 = selectedStu.class4;
            stu.Subject5 = selectedStu.class5;
            stu.Subject6 = selectedStu.class6;
            stu.Subject7 = selectedStu.class7;
            stu.Place1 = selectedStu.place1;
            stu.Place2 = selectedStu.place2;
            stu.Place3 = selectedStu.place3;
            stu.Place4 = selectedStu.place4;
            stu.Place5 = selectedStu.place5;
            stu.Place6 = selectedStu.place6;
            stu.Place7 = selectedStu.place7;
            try
            {
                ServiceReference1.Student std = stu;

                if (DateTime.Now.Hour == 7)
                {
                    if (stu.Place1.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place1.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place1.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (string.IsNullOrWhiteSpace(stu.Place1))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }

                }
                else if (DateTime.Now.Hour == 8 && DateTime.Now.Minute < 46)
                {
                    if (string.IsNullOrWhiteSpace(stu.Place2))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place2.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place2.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place2.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }
                else if ((DateTime.Now.Hour == 8 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 9 && DateTime.Now.Minute < 31))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place3))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place3.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place3.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place3.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 9 && DateTime.Now.Minute > 55) || (DateTime.Now.Hour == 10 && DateTime.Now.Minute < 46))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place4))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    }
                    if (stu.Place4.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place4.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place4.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 10 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 11 && DateTime.Now.Minute < 30))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place5))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place5.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place5.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place5.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 11 && DateTime.Now.Minute > 30) || (DateTime.Now.Hour == 12 && DateTime.Now.Minute < 15))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place6))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place6.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place6.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place6.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 12 && DateTime.Now.Minute > 15) || (DateTime.Now.Hour == 1))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place7))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place7.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    }
                    if (stu.Place7.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place7.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد دوام", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }

                students_Tabels s = new students_Tabels();

                students_Tabels.s1 = std.Subject1.ToString();
                students_Tabels.s2 = std.Subject2.ToString();
                students_Tabels.s3 = std.Subject3.ToString();
                students_Tabels.s4 = std.Subject4.ToString();
                students_Tabels.s5 = std.Subject5.ToString();
                students_Tabels.s6 = std.Subject6.ToString();
                students_Tabels.s7 = std.Subject7.ToString();
                students_Tabels.name = std.Name.ToString();
                students_Tabels.acc = std.AccNumber.ToString();
                students_Tabels n = new students_Tabels();
                n.ShowDialog();
                students_Tabels.deleteall();
                this.Hide();


            }
            catch (Exception)
            {
                //MessageBox.Show("اسم الطالب ليس موجود في النظام");
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
            if (textBox2.Text.Trim().Length < 5)
                return;
            var studnet1 = new
            {
                name = "شادي عصام عزت المصري",
                age = 12,
                class1 = "كيمياء3",
                place1 = "C1",
                class2 = "رياضيات4",
                place2 = "B2",
                class3 = "أحياء3",
                place3 = "B3",
                class4 = "فيزياء3",
                place4 = "A2",
                class5 = "إنجليزي4",
                place5 = "B1",
                class6 = "علم بيئة",
                place6 = "A12",
                class7 = "تربية مهنية",
                place7 = "C5"
            };
            var studnet2 = new
            {
                name = "أسامة محمد زكي هلال",
                age = 12,
                class1 = "كيمياء3",
                place1 = "C1",
                class2 = "رياضيات4",
                place2 = "B2",
                class3 = "أحياء3",
                place3 = "B3",
                class4 = "فيزياء3",
                place4 = "A2",
                class5 = "إنجليزي4",
                place5 = "B1",
                class6 = "علم بيئة",
                place6 = "A12",
                class7 = "تربية مهنية",
                place7 = "C5"
            };
            var studnet3 = new
            {
                name = "عبد العزيز عبد اللطيف المزين",
                age = 12,
                class1 = "كيمياء3",
                place1 = "C1",
                class2 = "رياضيات4",
                place2 = "B2",
                class3 = "أحياء3",
                place3 = "B3",
                class4 = "فيزياء3",
                place4 = "A2",
                class5 = "إنجليزي4",
                place5 = "B1",
                class6 = "علم بيئة",
                place6 = "A12",
                class7 = "تربية مهنية",
                place7 = "C5"
            };
            if (string.IsNullOrWhiteSpace(textBox2.Text.Trim()))
                return;
            Random R = new Random();
            int number = R.Next(0, 2);
            var selectedStu = studnet1;
            switch (number)
            {
                case 0:
                    break;
                case 1:
                    selectedStu = studnet2;
                    break;
                case 2:
                    selectedStu = studnet3;
                    break;
            }
            ServiceReference1.Student stu = new ServiceReference1.Student();
            stu.Subject1 = selectedStu.class1;
            stu.Subject2= selectedStu.class2;
            stu.Subject3= selectedStu.class3;
            stu.Subject4= selectedStu.class4;
            stu.Subject5= selectedStu.class5;
            stu.Subject6= selectedStu.class6;
            stu.Subject7= selectedStu.class7;
            stu.Place1 = selectedStu.place1;
            stu.Place2 = selectedStu.place2;
            stu.Place3= selectedStu.place3;
            stu.Place4= selectedStu.place4;
            stu.Place5= selectedStu.place5;
            stu.Place6= selectedStu.place6;
            stu.Place7= selectedStu.place7;
            try
            {
                //if (string.IsNullOrWhiteSpace(textBox2.Text))
                //    return;
                //ServiceReference1.StudentServiceClient St = new ServiceReference1.StudentServiceClient();
                //ServiceReference1.Student DO = St.GetStudentWithAcc(textBox2.Text);
                //MessageBox.Show(DO.Name);

                if (DateTime.Now.Hour == 7)
                {
                    if (stu.Place1.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place1.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place1.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (string.IsNullOrWhiteSpace(stu.Place1))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }

                }
                else if (DateTime.Now.Hour == 8 && DateTime.Now.Minute < 46)
                {
                    if (string.IsNullOrWhiteSpace(stu.Place2))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place2.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place2.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place2.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }
                else if ((DateTime.Now.Hour == 8 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 9 && DateTime.Now.Minute < 31))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place3))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place3.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place3.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place3.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 9 && DateTime.Now.Minute > 55) || (DateTime.Now.Hour == 10 && DateTime.Now.Minute < 46))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place4))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    }
                    if (stu.Place4.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place4.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place4.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 10 && DateTime.Now.Minute > 45) || (DateTime.Now.Hour == 11 && DateTime.Now.Minute < 30))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place5))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place5.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place5.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place5.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 11 && DateTime.Now.Minute > 30) || (DateTime.Now.Hour == 12 && DateTime.Now.Minute < 15))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place6))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place6.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place6.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place6.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني","",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                    }
                }

                else if ((DateTime.Now.Hour == 12 && DateTime.Now.Minute > 15) || (DateTime.Now.Hour == 1))
                {
                    if (string.IsNullOrWhiteSpace(stu.Place7))
                    {
                        MessageBox.Show("يوجد فراغ لدى الطالب الرجاء التوجه للمدير \n اذا لم تعرف مكان المدير اضغط على الخريطه ثم الدور الارضي", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place7.StartsWith("A"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل عبد الخالق الغامدي \n اذا لم تعرف موقع الوكيل اضغط الخريطه ثم المبنى الثاني و الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                    }
                    if (stu.Place7.StartsWith("B"))
                    {
                        MessageBox.Show("الرجاء التوجه الى الوكيل احمد الفقيه \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الاول", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    if (stu.Place7.StartsWith("C"))
                    {
                        MessageBox.Show("الرجاء التوجه الي الوكيل عندنان سيت \n اذا لم تعرف موقع الوكيل اضغط على الخريطه ثم الدور الثاني", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد دوام", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                //ServiceReference1.Student sttd = St.GetStudentWithAcc(textBox2.Text);
                students_Tabels.deleteall();
                students_Tabels.s1 = stu.Subject1.ToString();
                students_Tabels.s2 = stu.Subject2.ToString();
                students_Tabels.s3 = stu.Subject3.ToString();
                students_Tabels.s4 = stu.Subject4.ToString();
                students_Tabels.s5 = stu.Subject5.ToString();
                students_Tabels.s6 = stu.Subject6.ToString();
                students_Tabels.s7 = stu.Subject7.ToString();
                students_Tabels.name = stu.Name.ToString();
                students_Tabels.acc = stu.AccNumber.ToString();
                students_Tabels baby = new students_Tabels();
                baby.ShowDialog();
                this.Hide();
            }
            catch (Exception)
            {
                //MessageBox.Show("رقم الاكاديمي ليس موجود في النظام");
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
            //System.Diagnostics.Process.Start("osk.exe");
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcesses().Where(p => p.ProcessName == "osk.exe").Count() > 0)
                return;
            //System.Diagnostics.Process.Start("osk.exe");
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == '\b' || e.KeyChar == 127)
                e.Handled = false;
        }
    }
}