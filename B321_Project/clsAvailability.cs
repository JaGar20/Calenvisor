using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace B321_Project
{
    internal class clsAvailability
    {
        private int mAvailabilityID;
        private int mAdvisorID;
        private int mHourBlockID;
        private int mLocationID;
        private DateTime mAvailableDate;


        public int AvailabilityID
        {
            get { return mAvailabilityID; }
            set { mAvailabilityID = value; }
        
        }
        // Foreign Key //
        public int AdvisorID
        {
            get { return mAdvisorID; }
            set { mAdvisorID = value; }
        }

        public int HourBlockID
        {
            get { return mHourBlockID; }
            set { mHourBlockID = value; }
        }

        public int LocationID
        {
            get { return mLocationID; }
            set { mLocationID = value; }
        }

        public DateTime AvailableDate
        {
            get { return mAvailableDate; }
            set { mAvailableDate = value; }
        }


    }
}