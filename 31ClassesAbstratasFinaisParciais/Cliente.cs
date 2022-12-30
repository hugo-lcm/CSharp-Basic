using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31ClassesAbstratasFinaisParciais
{
    public abstract class Cliente
    {
        public string NomeCompleto { get; set; }
        public string Endereco { get; set; }
        public int Codigo { get; set; }

        // é feita apenas a assinatura dos métodos e não a implementação, as classes herdeiras que implementam (são obrigadas a implementar)
        public abstract void Incluir();

        public abstract void Excluir();
    }
}
