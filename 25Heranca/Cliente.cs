﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Heranca
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Status { get; set; }
        public int Codigo { get; set; }

        public bool Excluir()
        {
            Status = "excluído";
            return true;
        }

    }
}
