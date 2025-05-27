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
        private Dictionary<string, VehicleRecord> m_VehiclesInGarageRecords = new Dictionary<string, VehicleRecord>();

        private const string k_DbFilePath = "Vehicles.db";

        public void PrintVehiclesByLicensePlate(string i_LicensePlate)
        {
            bool isDone = GetVehicleRecord(i_LicensePlate, out VehicleRecord vehicleRecordToPrint);
            if(isDone)
            {
                vehicleRecordToPrint.Print();
            }
        }

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

        public bool GetVehicleRecord(string i_LicensePlate, out VehicleRecord o_VehicleRecord)
        {
            bool isDone = m_VehiclesInGarageRecords.TryGetValue(i_LicensePlate, out o_VehicleRecord);

            return isDone;
        }

        public bool GetVehicle(string i_LicensePlate, out Vehicle o_Vehicle)
        {
            o_Vehicle = null;
            bool isDone = m_VehiclesInGarageRecords.TryGetValue(i_LicensePlate, out VehicleRecord vehicleRecord);
            if(isDone)
            {
                o_Vehicle = vehicleRecord.Vehicle;
            }

            return isDone;
        }

        public VehicleRecord GetVehicleRecord(string i_LicensePlate)
        {
            bool isDone = m_VehiclesInGarageRecords.TryGetValue(i_LicensePlate, out VehicleRecord vehicleRecord);
            return vehicleRecord;
        }

        public string GetVehicleType(string i_LicensePlate)
        {
            string vehicleType = "NOT_FOUND";
            foreach (string line in File.ReadLines(k_DbFilePath))
            {
                if (line.Contains(i_LicensePlate))
                {
                    int position = line.IndexOf(",");
                    vehicleType = line.Substring(0,position);
                }
            }

            return vehicleType;
        }

    }
}
