using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32MetodosAbstratos
{
    internal class PessoaFisica : Cliente
    {
        private int _cpf;

        public int Cpf
        {
            get => _cpf;
            set => _cpf = value;

        }

        public PessoaFisica(string nome, int cpf)
        {
            this.Nome = nome;
            this._cpf = cpf;
        }

        public override string AlterarNome(string nome)
        {
            this.Nome = nome;
            return $"nome {Nome} atualizado";
        }
    }
}
