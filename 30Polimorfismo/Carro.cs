using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Polimorfismo
{
    public class Carro : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("carro ligado");
        }

        public override void Desligar()
        {
            Console.WriteLine("carro desligado");
        }
    }
}
