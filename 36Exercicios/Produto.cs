using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _36Exercicios
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this._quantidade = quantidade;
        }

        public void AdicinarEstoque(int quantidade)
        {
            this._quantidade += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            this._quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"produto: {this.Nome}\npreço: R${this.Preco}\nquantidade: {this._quantidade}";
        }
    }
}
