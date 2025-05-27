using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class VehicleRecord
    {
        private string m_OwnerName;
        private string m_OwnerPhone;
        public Enum.eVehicleStatus VehicleStatus { get; set; }
        public Vehicle Vehicle { get; set; }

        public void Print()
        {
            Console.WriteLine($"Owner name: {m_OwnerName}" + $"Phone: {m_OwnerPhone}");
        }
    }
}

