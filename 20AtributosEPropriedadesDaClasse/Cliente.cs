using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20AtributosEPropriedadesDaClasse
{
    internal class Cliente
    {
        // para fazer um set/get com alguma logica, tem que ser dessa forma
        private int _codigo;
        private string _nomeCLiente;
        // já dessa forma, o compilador vai criar um campo privado associado a propriedade
        public List<string> Familiares { get; set; } // não é "correto" uma propriedade do tipo lista por causa do .clear()
        public bool Ativo { get; set; }

        public int Codigo
        {
            get => _codigo;
            set => _codigo = value;
        }

        public string NomeCLiente
        {
            get => _nomeCLiente;
            set
            {
                if (value.ToLower() == "hugo")
                {
                    _nomeCLiente = value + " Leonardo";
                }
                else
                {
                    _nomeCLiente = value;
                }
            }
        }
    }
}
