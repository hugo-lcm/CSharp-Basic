using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Polimorfismo
{
    public class Moto : Veiculo
    {
        public override void Ligar()
        {
            Console.WriteLine("moto ligada");
        }

        public override void Desligar()
        {
            Console.WriteLine("moto desligada");
        }
    }
}
