using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ISchool.WebService.Students
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        List<Student> GetAllStudentByRange(int Start, int End);
        [OperationContract]
        Student GetStudentWithAcc(string WACC);
        [OperationContract]
        Student GetStudentWithLikleyName(string LNAME);
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public string AccNumber { get; set; }
        [DataMember]
        public string Name { get; set; }
        #region Schedule
        [DataMember]
        public string Subject1 { get; set; }
        [DataMember]
        public string Place1 { get; set; }
        [DataMember]
        public string Subject2 { get; set; }
        [DataMember]
        public string Place2 { get; set; }
        [DataMember]
        public string Subject3 { get; set; }
        [DataMember]
        public string Place3 { get; set; }
        [DataMember]
        public string Subject4 { get; set; }
        [DataMember]
        public string Place4 { get; set; }
        [DataMember]
        public string Subject5 { get; set; }
        [DataMember]
        public string Place5 { get; set; }
        [DataMember]
        public string Subject6 { get; set; }
        [DataMember]
        public string Place6 { get; set; }
        [DataMember]
        public string Subject7 { get; set; }
        [DataMember]
        public string Place7 { get; set; }
        [DataMember]
        public string Subject8 { get; set; }
        [DataMember]
        public string Place8 { get; set; }
#endregion
    }
}
