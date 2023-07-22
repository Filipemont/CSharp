using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPraticoHerancaPolimorfismo.Entities {
    internal class UsedProduct : Product{
        public DateTime Date { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime date) : base ( name, price){
           Date = date;
        }

        public override string PriceTag() {
            return Name
                + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + Date.ToString("dd/MM/yyyy") + ")"; ;
        }
    }
}
