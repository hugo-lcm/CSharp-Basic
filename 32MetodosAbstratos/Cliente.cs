using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32MetodosAbstratos
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }

        public abstract string AlterarNome(string nome);
    }
}
