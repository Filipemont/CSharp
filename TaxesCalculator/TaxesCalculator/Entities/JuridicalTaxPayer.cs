using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator.Entities
{
    internal class JuridicalTaxPayer : Taxes
    {
        public int EmployeeQuantity { get; set; }

        public JuridicalTaxPayer(int employeeQuantity, string name, double anualIncome) : base(name, anualIncome)
        {
            EmployeeQuantity = employeeQuantity;
        }


        public override double AnualPaymentTaxes()
        {
            if (EmployeeQuantity > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            } 
        }
    }
}
