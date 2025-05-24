using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.Enum;

namespace Ex03.GarageLogic
{
    internal class ElectricEngine
    {
        private float m_RemainingBatteryTimeHours;
        private float m_MaxBatteryTimeHours;

        private bool recharge(float i_Hours)
        {
            bool isDone = false;
            if (!isBatteryOverload(i_Hours))
            {
                m_RemainingBatteryTimeHours += i_Hours;
                isDone = true;
            }

            return isDone;
        }

        private bool isBatteryOverload(float i_Hours)
        {
            return (m_RemainingBatteryTimeHours + i_Hours > m_MaxBatteryTimeHours);
        }
    }
}
