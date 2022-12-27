using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Encapsulamento
{
    public class Cliente
    {
        protected string status;
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public string Status
        {
            get => status;
            set => status = value;
        }
    }
}
