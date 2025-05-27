using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class Truck : Vehicle
    {
        public FuelEngine Engine { get; set; }
        private bool m_IsHazmatVehicle;
        private float m_LoadVolume;

        protected Truck(string i_LicenseID, string i_ModelName)
        {
            
        }
    }
}
