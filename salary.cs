using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    abstract class Salary
    {

        

        protected double Pay(double salary) {

            return salary;
        }
        protected double Pay(double salary, int hours) {

            return salary*hours;
        }
    }
}
