using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double PerHour { get; set; }

        public Employee() { }
        public Employee(string name, int hours, double perHour)
        {
            Name = name;
            Hours = hours;
            PerHour = perHour;
        }
        public virtual double Payment()
        {
            return Hours * PerHour;
        }
    }
}
