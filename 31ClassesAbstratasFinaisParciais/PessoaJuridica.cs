using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31ClassesAbstratasFinaisParciais
{
    public sealed class PessoaJuridica : Cliente
    {
        public int Cnpj { get; set; }

        public PessoaJuridica(int cpnj)
        {
            this.Cnpj = cpnj;
        }

        public override void Incluir()
        {
            Console.WriteLine($"cpnj {this.Cnpj} incluído");
        }

        public override void Excluir()
        {
            Console.WriteLine($"cpnj {this.Cnpj} excluído");
        }
    }
}
