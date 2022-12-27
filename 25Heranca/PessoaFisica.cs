using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Heranca
{
    public class PessoaFisica : Cliente
    {
        public int Cpf { get; set; }

        public PessoaFisica(string nome, int cpf, string endereco, string telefone, string status, int codigo)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Status = status;
            this.Codigo = codigo;
        }

        public bool Incluir()
        {
            Status = $"{Cpf} incluído";
            return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"nome: {Nome}\n" +
                $"cpf: {Cpf}\n" +
                $"endereço: {Endereco}\n" +
                $"telefone: {Telefone}\n" +
                $"status: {Status}\n" +
                $"codigo: {Codigo}");
        }
    }
}
