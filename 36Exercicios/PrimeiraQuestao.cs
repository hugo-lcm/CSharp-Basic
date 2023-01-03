using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36Exercicios
{
    public static class PrimeiraQuestao
    {
        public static void CalcularQuantidadeAzulejos()
        {
            Console.WriteLine("qual a altura da parede?");
            double hp = Double.Parse(Console.ReadLine());

            Console.WriteLine("qual a largura da parede?");
            double lp = Double.Parse(Console.ReadLine());

            Console.WriteLine("qual a altura do azulejo?");
            double ha = Double.Parse(Console.ReadLine());

            Console.WriteLine("qual a largura do azulejo?");
            double la = Double.Parse(Console.ReadLine());

            int numAzulejos = (int)Math.Ceiling(hp * lp / (ha * la));
            Console.WriteLine($"serão necessários {numAzulejos} para cobrir a parede");
        }
    }
}
