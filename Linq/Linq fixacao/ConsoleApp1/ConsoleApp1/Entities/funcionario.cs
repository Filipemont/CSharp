using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }


        public override string ToString()
        {
            return Nome +
                " " +
                Email +
                " " +
                Salario;
        }
    }
}
