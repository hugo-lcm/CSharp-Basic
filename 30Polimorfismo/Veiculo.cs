using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30Polimorfismo
{
    public class Veiculo
    {
        public virtual void Ligar()
        {
            Console.WriteLine("veiculo ligado");
        }

        public virtual void Desligar()
        {
            Console.WriteLine("veiculo desligado");
        }
    }
}
