using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;
using Enum = Ex03.GarageLogic.Enum;

namespace Ex03.ConsoleUI
{
    internal class UserRequests
    {
        private GarageManager m_GarageManager = new GarageManager();
        private void refillEnergy(string i_LicensePlate)
        {
            Vehicle vehicleToRefill;
            bool isVehicleExist = m_GarageManager.GetVehicle(i_LicensePlate, out vehicleToRefill);
            if(!isVehicleExist)
            {
                return; //Exception?
            }

            if(vehicleToRefill.Engine is FuelEngine)
            {

            }
            string vehicleType = vehicleToRefill.VehicleType;
            if (vehicleType.Contains("Electric"))
            {
                Console.WriteLine("Enter Minutes To Charge:");
                int min = int.Parse(Console.ReadLine());
                vehicleToRefill.Engine.RefillEnergy(min,Enum.eEnergyType.Electric);
            }
            else if (vehicleType.Contains("Fuel"))
            {
                Console.WriteLine("Enter Type of Fuel:");
                Enum.eEnergyType fuelType = (Enum.eEnergyType)int.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount of fuel:");
                int amountFuel = int.Parse(Console.ReadLine());
                vehicleToRefill.Engine.RefillEnergy(amountFuel, fuelType);
            }
        }

        public void PrintRecord(string i_LicensePlate)
        {
            m_GarageManager.PrintVehiclesByLicensePlate(i_LicensePlate);
        }
    }
}
