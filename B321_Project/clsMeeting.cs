using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B321_Project
{
    internal class clsMeeting
    {
        public clsMeeting() { }
        private int mMeetingID;

        private int mStudentID;
        private int mAvailabilityID;
        private string mMeetingName;
        private string mStatus;

        public int MeetingID
        {
            get { return mMeetingID; }
            set { mMeetingID = value; }
        }
        public int StudentID
        {
            get { return mStudentID; }
            set { mStudentID = value; }
        }

        public int AvailabilityID
        {
            get { return mAvailabilityID; }
            set { mAvailabilityID = value; }
        }

        public string MeetingName
        {
            get { return mMeetingName; }
            set { mMeetingName = value; }
        }

        public string Status
        {
            get { return mStatus; }
            set { mStatus = value; }
        }



    }
}
