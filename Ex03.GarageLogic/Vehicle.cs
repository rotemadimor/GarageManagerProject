using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.Enum;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        public Engine Engine { get; }
        public string VehicleType { get; set; }
        public string ModelName { get; set; }
        public string LicensePlate { get; set; }
        private float m_EnergyPercentage;
        public List<Tire> TireList { get; set; }
        public class Tire
        {
            private string m_TireModel;
            private float m_CurrAirPressure;
            private float m_MaxAirPressure;
            private bool tireInflation(float i_AmountOfAirToAdd)
            {
                bool isDone = false;
                if (!isAirOverload(i_AmountOfAirToAdd))
                {
                    m_CurrAirPressure += i_AmountOfAirToAdd;
                    isDone = true;
                }

                return isDone;
            }
            public void TireInflationToMax()
            {
                m_CurrAirPressure = m_MaxAirPressure;
            }
            private bool isAirOverload(float i_AmountOfAirToAdd)
            {
                return (m_CurrAirPressure + i_AmountOfAirToAdd > m_MaxAirPressure);
            }
        }
        public void InflationAllTiresToMax()
        {
            foreach (Tire tire in TireList)
            {
                tire.TireInflationToMax();
            }
        }
    }
}