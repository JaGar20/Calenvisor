using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B321_Project
{
    internal class clsHourBlock
    {
        private int mHourBlockID;
        private string mStartBlock;
        private string mEndBlock;

        public int HourBlockID
        {
            get { return mHourBlockID; }
            set { mHourBlockID = value; }
        }

        public string StartBlock
        {
            get { return mStartBlock; }
            set { mStartBlock = value; }
        }

        public string EndBlock
        {
            get { return mEndBlock; }
            set { mEndBlock = value; }
        }
        public clsHourBlock() { }
    }
}
