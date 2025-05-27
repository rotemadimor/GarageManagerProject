using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.Enum;

namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        public abstract void RefillEnergy(float i_AmountToFill, eEnergyType i_EnergyType);

        public void doSomething()
        {

        }
    }
}
