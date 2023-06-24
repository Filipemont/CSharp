using System;

namespace QuestaoEstoqueClasseEMetodo {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
            
        }
        public void AdicionarProdutos() {

        }
        public void RemoverProdutos() {

        }
    }
}
