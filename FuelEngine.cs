using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class FuelEngine
    {
        private Enum.eFuelType m_FuelType;
        private float m_CurrFuelAmountLiters;
        private float m_MaxFuelAmountLiters;

        private bool refuel(float i_Liters, Enum.eFuelType i_FuelType)
        {
            bool isDone = false;
            if(i_FuelType == m_FuelType && !isFuelOverload(i_Liters))
            {
                m_CurrFuelAmountLiters+= i_Liters;
                isDone = true;
            }

            return isDone;
        }

        private bool isFuelOverload(float i_Liters)
        {
            return (m_CurrFuelAmountLiters + i_Liters > m_MaxFuelAmountLiters);
        }
    }
}
