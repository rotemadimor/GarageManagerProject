using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {
        private string m_VehicleType;
        private string m_ModelName;
        private string m_LicensePlate;
        private float m_EnergyPercentage;
        private List<Tire> m_TireList;

        internal class Tire
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

            private bool isAirOverload(float i_AmountOfAirToAdd)
            {
                return (m_CurrAirPressure + i_AmountOfAirToAdd > m_MaxAirPressure);
            }
        }
    }
}
