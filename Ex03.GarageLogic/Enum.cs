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

        public enum eEnergyType
        {
            Soler,
            Octan95,
            Octan96,
            Octan98,
            Electric
        }

        public enum eVehicleStatus
        {
            InProgress,
            Done,
            Paid
        }
    }
}
