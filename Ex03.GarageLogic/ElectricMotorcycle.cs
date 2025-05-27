using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.Enum;

namespace Ex03.GarageLogic
{
    internal class ElectricMotorcycle : Motorcycle
    {
        public ElectricEngine Engine { get; set; }

        public ElectricMotorcycle(string i_LicenseID, string i_ModelName)
        {
                Engine.RefillEnergy();
        }
    }
}
