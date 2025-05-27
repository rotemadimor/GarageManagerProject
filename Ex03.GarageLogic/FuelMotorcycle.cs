using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelMotorcycle : Motorcycle
    {
        public FuelEngine Engine { get; set; }

        public FuelMotorcycle(string i_LicenseID, string i_ModelName)
        {
            
        }
    }
}
