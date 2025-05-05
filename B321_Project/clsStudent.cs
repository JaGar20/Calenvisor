using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B321_Project
{
    internal class clsStudent
    {
        private int mStudentID;
        private string mStudentFName;
        private string mStudentMName;
        private string mStudentLName;
        private string mStudentEmail;
        private string mUSCBID; 

        public int StudentID
        {
            get { return mStudentID; }
            set { mStudentID = value; }
        }

        public string StudentFName
        {
            get { return mStudentFName; }
            set { mStudentFName = value; }
        }   

        public string StudentMName
        {
            get { return mStudentMName; }
            set { mStudentMName = value; }
        }

        public string StudentLName
        {
            get { return mStudentLName; }
            set { mStudentLName = value; }
        }
        public string StudentEmail
        {
            get { return mStudentEmail; }
            set { mStudentEmail = value; }
        }
        public string USCBID
        {
            get { return mUSCBID; }
            set { mUSCBID = value; }
        }   

        public clsStudent() { }
    }
}
