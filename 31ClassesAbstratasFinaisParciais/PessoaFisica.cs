using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _31ClassesAbstratasFinaisParciais
{
    public sealed class PessoaFisica : Cliente
    {
        public int Cpf { get; set; }

        public PessoaFisica(int cpf)
        {
            this.Cpf = cpf;
        }

        public override void Incluir()
        {
            Console.WriteLine($"cpf {this.Cpf} incluído");
        }

        public override void Excluir()
        {
            Console.WriteLine($"cpf {this.Cpf} excluído");
        }
    }
}
