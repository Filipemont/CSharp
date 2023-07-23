using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator.Entities
{
    internal abstract class Taxes
    {
        public string  Name { get; set; }
        public double AnualIncome { get; set; }

        protected Taxes(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double AnualPaymentTaxes();
    }
}
