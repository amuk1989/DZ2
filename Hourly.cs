﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Hourly: Salary
    {
        public double Money(double _salary, int _hours)
        {
            return Pay(_salary, _hours);
        }
    }
}
