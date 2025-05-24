using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        private List<VehicleRecord> m_vehiclesInGarageRecords;
        private const string k_DbFilePath = "./Vehicles.db";

        public void LoadAllVehicles()
        {
            foreach (string line in File.ReadLines(k_DbFilePath))
            {
                if(line.Contains("*"))
                {
                    break;
                }
                Console.WriteLine(line);
            }

            Console.ReadLine();

        }
    }
}
