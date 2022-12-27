using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Encapsulamento
{
    public class PessoaJuridica : Cliente
    {
        private int Cnpj { get; set; }

        public PessoaJuridica(string nome, int codigo, int cnpj)
        {
            Nome = nome;
            Status = "valor inicial";
            Codigo = codigo;
            Cnpj = cnpj;
        }

        public void Incluir()
        {
            Status = $"{Cnpj} incluído";
        }
    }
}
