using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B321_Project
{
    internal class clsLocation
    {
        private int mLocationID;
        private string mLocationType;

        public int LocationID
        {
            get { return mLocationID; }
            set { mLocationID = value; }
        }

        public string LocationType
        {
            get { return mLocationType; }
            set { mLocationType = value; }
        }
        public ICollection<clsAvailability> Availability { get; set; } = new List<clsAvailability>();

        public clsLocation() { }

    }
}
