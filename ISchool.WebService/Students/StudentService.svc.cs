using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ISchool.WebService.Students
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        public List<Student> GetAllStudentByRange(int Start, int End)
        {
            List<Student> Back = new List<Student>();
            using (DataBasePart.obksdatabaserrEntities Db = new DataBasePart.obksdatabaserrEntities())
            {
                Db.Database.Connection.ConnectionString = "Server=sql5030.smarterasp.net;Database=DB_A14789_obksdatabaserr;User Id=DB_A14789_obksdatabaserr_admin;Password = Azq1212212144; ";
                int i = 0;
                List<DataBasePart.st_students> St = Db.st_students.ToList();
                foreach (DataBasePart.st_students item in St)
                {
                    if (i < Start)
                    {
                        i++;
                        continue;
                    }
                    i++;
                    Student newone = new Student();
                    newone.AccNumber = item.st_acc;
                    newone.Name = item.st_name;
                    newone.Place1 = item.st_subject1_place;
                    newone.Place2 = item.st_subject2_place;
                    newone.Place3 = item.st_subject3_place;
                    newone.Place4 = item.st_subject4_place;
                    newone.Place5 = item.st_subject5_place;
                    newone.Place6 = item.st_subject6_place;
                    newone.Place7 = item.st_subject7_place;
                    newone.Subject1 = item.st_subject1;
                    newone.Subject2 = item.st_subject2;
                    newone.Subject3 = item.st_subject3;
                    newone.Subject4 = item.st_subject4;
                    newone.Subject5 = item.st_subject5;
                    newone.Subject6 = item.st_subject6;
                    newone.Subject7 = item.st_subject7;
                    Back.Add(newone);
                    if (i > End)
                        break;
                }
            }
            BasicHttpBinding httpBinding = new BasicHttpBinding();
            httpBinding.MaxReceivedMessageSize = 2147483647;
            httpBinding.MaxBufferSize = 2147483647;
            return Back;
        }
        public Student GetStudentWithAcc(string WACC)
        {
            List<Student> Back = new List<Student>();
            using (DataBasePart.obksdatabaserrEntities Db = new DataBasePart.obksdatabaserrEntities())
            {
                Db.Database.Connection.ConnectionString = "Server=sql5030.smarterasp.net;Database=DB_A14789_obksdatabaserr;User Id=DB_A14789_obksdatabaserr_admin;Password = Azq1212212144; ";

                List<DataBasePart.st_students> St = Db.st_students.Where(obj => obj.st_acc == WACC).ToList();
                foreach (DataBasePart.st_students item in St)
                {
                    Student newone = new Student();
                    newone.AccNumber = item.st_acc;
                    newone.Name = item.st_name;
                    newone.Place1 = item.st_subject1_place;
                    newone.Place2 = item.st_subject2_place;
                    newone.Place3 = item.st_subject3_place;
                    newone.Place4 = item.st_subject4_place;
                    newone.Place5 = item.st_subject5_place;
                    newone.Place6 = item.st_subject6_place;
                    newone.Place7 = item.st_subject7_place;
                    newone.Subject1 = item.st_subject1;
                    newone.Subject2 = item.st_subject2;
                    newone.Subject3 = item.st_subject3;
                    newone.Subject4 = item.st_subject4;
                    newone.Subject5 = item.st_subject5;
                    newone.Subject6 = item.st_subject6;
                    newone.Subject7 = item.st_subject7;
                    return newone;
                }
                return null;
            }
        }

        public Student GetStudentWithLikleyName(string LNAME)
        {
            List<Student> Back = new List<Student>();
            using (DataBasePart.obksdatabaserrEntities Db = new DataBasePart.obksdatabaserrEntities())
            {
                Db.Database.Connection.ConnectionString = "Server=sql5030.smarterasp.net;Database=DB_A14789_obksdatabaserr;User Id=DB_A14789_obksdatabaserr_admin;Password = Azq1212212144; ";

                List<DataBasePart.st_students> St = Db.st_students.Where(d => d.st_name.ToLower().Contains(LNAME.ToLower())).ToList();
                foreach (DataBasePart.st_students item in St)
                {
                    Student newone = new Student();
                    newone.AccNumber = item.st_acc;
                    newone.Name = item.st_name;
                    newone.Place1 = item.st_subject1_place;
                    newone.Place2 = item.st_subject2_place;
                    newone.Place3 = item.st_subject3_place;
                    newone.Place4 = item.st_subject4_place;
                    newone.Place5 = item.st_subject5_place;
                    newone.Place6 = item.st_subject6_place;
                    newone.Place7 = item.st_subject7_place;
                    newone.Subject1 = item.st_subject1;
                    newone.Subject2 = item.st_subject2;
                    newone.Subject3 = item.st_subject3;
                    newone.Subject4 = item.st_subject4;
                    newone.Subject5 = item.st_subject5;
                    newone.Subject6 = item.st_subject6;
                    newone.Subject7 = item.st_subject7;
                    return newone;
                }
                return null;
            }
        }
    }
}
