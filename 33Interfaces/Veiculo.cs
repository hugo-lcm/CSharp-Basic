using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33Interfaces
{
    // se for usar herança e interface, herança vem primeiro, após os :
    public abstract class Veiculo : IVeiculo
    {
        public abstract string Ligar();

        public abstract string Desligar();

        public abstract string Abastecer();

        public string Desabasatecer()
        {
            return "o veículo foi desabastecido";
        }
    }
}
