using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36Exercicios
{
    public static class SegundaQuestao
    {
        public static void CalcularImposto()
        {

            Console.WriteLine("digite a área total do terreno: ");
            double areaTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a área construída do terreno: ");
            double areaConstruida = double.Parse(Console.ReadLine());

            double valorTotal = (areaConstruida * 5) + (areaTotal - areaConstruida) * 3.80;

            Console.WriteLine($"o valor total a ser pago é R${valorTotal}");
        }
    }
}
