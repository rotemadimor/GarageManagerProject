﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    internal class Program
    {
        public static void Main()
        {
            GarageLogic.GarageManager gm = new GarageManager();
            gm.LoadAllVehicles();
        }
    }
}
