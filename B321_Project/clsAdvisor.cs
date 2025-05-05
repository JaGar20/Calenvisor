using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B321_Project
{
    internal class clsAdvisor
    {
        private int mAdvisorID;
        private string mAdvisorFName;
        private string mAdvisorMName;
        private string mAdvisorLName;
        private string mAdvisorEmail;
        private string mOfficeAddress;
        private string mPhoneNumber;

        public int AdvisorID
        {
            get { return mAdvisorID; }
            set { mAdvisorID = value; }
        }

        public string AdvisorFName
        {
            get { return mAdvisorFName; }
            set { mAdvisorFName = value; }
        }

        public string AdvisorMName
        {
            get { return mAdvisorMName; }
            set { mAdvisorMName = value; }
        }

        public string AdvisorLName
        {
            get { return mAdvisorLName; }
            set { mAdvisorLName = value; }
        }

        public string AdvisorEmail
        {
            get { return mAdvisorEmail; }
            set { mAdvisorEmail = value; }
        }

        public string OfficeAddress
        {
            get { return mOfficeAddress; }
            set { mOfficeAddress = value; }
        }

        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }

        public clsAdvisor() { }
    }
}
