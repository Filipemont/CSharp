using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayComObjetosDeClasse {
    internal class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }
    
        public Produto(string nome, double preco) {
            Preco = preco;
            Nome = nome;     
        } 
    }
}
