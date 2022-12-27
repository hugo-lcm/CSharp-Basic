using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SobrecargaDeMetodos
{
    internal class Conexao
    {
        /*
        class Exemplo
        {
            1 - Variáveis/Campos
            2 - Propriedades
            3 - Métodos
        }
        */
        private string Status { get; set; }

        public Conexao()
        {
            Status = "construtor padrão";
        }

        public bool Conectar()
        {
            Status = "conectado com sucesso";
            return true;
        }

        public bool Conectar(string banco)
        {
            Status = "conectado com sucesso";
            return true;
        }

        public bool Conectar(string banco, string nome, string senha)
        {
            Status = "conectado com sucesso";
            return true;
        }

        public bool Desconectar()
        {
            Status = "deconectado com sucesso";
            return true;
        }
    }
}
