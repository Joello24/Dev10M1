using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Backend
{
    internal class Guest
    {
        private int id { get; set; }
        private string name { get; set; }
        private bool checkedIn { get; set; }
        private DateTime checkInTime { get; set; }
        private DateTime checkOutTime { get; set; }
        private int roomNumber { get; set; }

        Guest() { }

        Guest(int id, int roomNumber, DateTime checkInTime, DateTime checkOutTime, String name)
        {
            this.id = id;
            this.name = name;
            this.roomNumber = roomNumber;
            this.checkInTime = checkInTime;
            this.checkOutTime = checkOutTime;
        }
    }
}
