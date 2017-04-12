using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excl = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inserter
{
    class Program
    {
        static void Main(string[] args)
        {

            gg();
            return;
            Excl.Application App = new Excl.Application();
            Excl.Workbook WB = App.Workbooks.Open(@"D:\Securty Docs\OBKS DB\New\Very New\CS_GetStudentScheduleReport.xls");
            Excl.Worksheet CurrentSheet = WB.Worksheets[1];
            SqlConnection Con = new SqlConnection("Server=sql5030.smarterasp.net;Database=DB_A14789_obksdatabaserr;User Id=DB_A14789_obksdatabaserr_admin;Password = Azq1212212144; ");
            Con.Open();
            new SqlCommand("DELETE FROM st_students", Con);
            Con.Close();
//            Con.Open();
//            new SqlCommand("CREATE TABLE[dbo].[st_students](" +
//  "  [st_acc][varchar](5) NOT NULL," +
//  "  [st_name][nvarchar](150) NULL," +
// "   [st_subject1][nchar](100) NULL," +
//  "  [st_subject1_place][nchar](100) NULL," +
//  "  [st_subject2][nchar](100) NULL," +
//   " [st_subject2_place][nchar](100) NULL," +
//   " [st_subject3][nchar](100) NULL," +
//  "  [st_subject3_place][nchar](100) NULL," +
//  "  [st_subject4][nchar](100) NULL," +
//  "  [st_subject4_place][nchar](100) NULL," +
//  "  [st_subject5][nchar](100) NULL," +
//  "  [st_subject5_place][nchar](100) NULL," +
// "   [st_subject6][nchar](100) NULL," +
//  "  [st_subject6_place][nchar](100) NULL," +
//"   [st_subject7][nchar](100) NULL," +

//"   [st_subject7_place][nchar](100) NULL," +
//"   [st_subject8][nchar](100) NULL," +
//"   [st_subject8_place][nchar](100) NULL," +
//" CONSTRAINT[PK_st_students] PRIMARY KEY CLUSTERED" +
//"(" +
//"  [st_acc] ASC" +
//")WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]" +
//") ON[PRIMARY]" , Con).ExecuteNonQuery();
//            Con.Close();
            for (int i = 17; i < 3838; i = i + 5)
            {
                //st_students stn = new st_students();
                //stn.st_acc = Convert.ToString(CurrentSheet.Cells[i, "AB"].Value);
                //stn.st_name = Convert.ToString(CurrentSheet.Cells[i, "AA"].Value);
                //stn.st_subject1 = Convert.ToString(CurrentSheet.Cells[i, "Y"].Value);
                //stn.st_subject1_place = Convert.ToString(CurrentSheet.Cells[i, "X"].Value);
                //stn.st_subject2 = Convert.ToString(CurrentSheet.Cells[i, "W"].Value);
                //stn.st_subject2_place = Convert.ToString(CurrentSheet.Cells[i, "V"].Value);
                //stn.st_subject3 = Convert.ToString(CurrentSheet.Cells[i, "U"].Value);
                //stn.st_subject3_place = Convert.ToString(CurrentSheet.Cells[i, "S"].Value);
                //stn.st_subject4 = Convert.ToString(CurrentSheet.Cells[i, "Q"].Value);
                //stn.st_subject4_place = Convert.ToString(CurrentSheet.Cells[i, "P"].Value);
                //stn.st_subject5 = Convert.ToString(CurrentSheet.Cells[i, "N"].Value);
                //stn.st_subject5_place = Convert.ToString(CurrentSheet.Cells[i, "L"].Value);
                //stn.st_subject6 = Convert.ToString(CurrentSheet.Cells[i, "J"].Value);
                //stn.st_subject6_place = Convert.ToString(CurrentSheet.Cells[i, "I"].Value);
                //stn.st_subject7 = Convert.ToString(CurrentSheet.Cells[i, "G"].Value);
                //stn.st_subject7_place = Convert.ToString(CurrentSheet.Cells[i, "E"].Value);
                //stn.st_subject8 = Convert.ToString(CurrentSheet.Cells[i, "C"].Value);
                //stn.st_subject8_place = Convert.ToString(CurrentSheet.Cells[i, "B"].Value);
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "INSERT INTO st_students VALUES" +
                    "(N'" + CurrentSheet.Cells[i, "Z"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "Y"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "W"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "V"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "U"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "R"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "Q"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "P"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "N"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "L"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "J"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "H"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "F"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "D"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "C"].Value + "'," +
                    "N'" + CurrentSheet.Cells[i, "B"].Value + "',N'',N'')";
                Cmd.Connection = Con;
                //Db.st_students.Add(stn);
                //Db.SaveChanges();
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                Console.WriteLine(i + " Done");
            }
            Console.ReadKey();
        }

        public static void gg()
        {
            ServiceReference1.StudentServiceClient St = new ServiceReference1.StudentServiceClient();

            ServiceReference1.Student item = St.GetStudentWithAcc("35043");

            MessageBox.Show($"You Recive {item.Name} From Web Service");
     
            Console.ReadKey();
        }
    }
}
