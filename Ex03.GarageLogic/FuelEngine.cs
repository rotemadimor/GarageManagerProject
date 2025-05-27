using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.Enum;

namespace Ex03.GarageLogic
{
    internal class FuelEngine : Engine
    {
        private Enum.eEnergyType m_FuelType;
        private float m_CurrFuelAmountLiters;
        private float m_MaxFuelAmountLiters;

        public override void RefillEnergy(float i_AmountToFill, eEnergyType i_EnergyType)
        {
            Refuel(i_AmountToFill, i_EnergyType);
        }

        public bool Refuel(float i_Liters, Enum.eEnergyType i_FuelType)
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
