using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _23MetodosDasClasses
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int QuantidadePortas { get; set; }
        private List<string> antigosDonos;

        public Carro() { }

        // se nao for passado a qtd de portas quando instanciar, o valor padrao será 2
        public Carro(string marca, string modelo, int qtdPortas = 2)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.QuantidadePortas = qtdPortas;
        }
        public Carro(string modelo, int anoFabricacao)
        {
            this.Modelo = modelo;
            this.AnoFabricacao = anoFabricacao;
            this.antigosDonos = new List<string>();
        }

        // resolvendo o problema da aula 20, agora nao é possível dar .clear() na lista
        public void AddAntigoDono(string nome)
        {
            antigosDonos.Add(nome);
        }

        public List<string> GetAntigosDonos()
        {
            return antigosDonos;
        }

        public static int GetIdadeCarro(int anoFabricacao)
        {
            int anoAtual = DateTime.Today.Year;
            return anoAtual - anoFabricacao;

        }

    }
}
