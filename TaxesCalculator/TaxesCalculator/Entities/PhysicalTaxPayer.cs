using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator.Entities
{
    internal class PhysicalTaxPayer : Taxes
    {
        public double HealthCare { get; set; }

        public PhysicalTaxPayer(double healthCare, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthCare = healthCare;
        }
        public override double AnualPaymentTaxes()
        {
            if (HealthCare > 0 && AnualIncome >= 20000.00)
            {
                return (AnualIncome * 0.25) - (HealthCare * 0.5);
            }
            else if (HealthCare == 0 && AnualIncome >= 20000.00)
            {
                return AnualIncome * 0.25;
            }
            else if (HealthCare > 0 && AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthCare * 0.5);
            }
            else
            {
                return AnualIncome * 0.15;
            }
        }
    }
}
