using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Enum
    {
        public enum eColor
        {
            Yellow,
            Black,
            White,
            Silver,
        }

        public enum eLicenseType
        {
           A,
           A2,
           AB,
           B2
        }

        public enum eFuelType
        {
            Soler,
            Octan95,
            Octan96,
            Octan98
        }

        public enum eVehicleStatus
        {
            InProgress,
            Done,
            Paid
        }
    }
}
