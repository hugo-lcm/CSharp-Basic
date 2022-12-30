using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33Interfaces
{
    internal class Carro : Veiculo
    {
        public override string Abastecer()
        {
            return "carro abastecido";
        }

        public override string Desligar()
        {
            return "carro desligado";
        }

        public override string Ligar()
        {
            return "carro ligado";
        }
    }
}
