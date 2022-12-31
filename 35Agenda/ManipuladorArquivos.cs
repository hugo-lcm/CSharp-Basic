using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _35Agenda
{
    public class ManipuladorArquivos
    {
        private static string FILE_PATH = AppDomain.CurrentDomain.BaseDirectory + "contatos.txt";

        public static List<Contato> LerArquivo()
        {
            List<Contato> contatosList = new List<Contato>();
            if (File.Exists(@FILE_PATH))
            {
                using (StreamReader sr = File.OpenText(@FILE_PATH))
                {
                    while (sr.Peek() >= 0)
                    {
                        string linha = sr.ReadLine();
                        string[] linhaComSplit = linha.Split(';');
                        if (linhaComSplit.Count() == 3)
                        {
                            Contato contato = new Contato();
                            contato.Nome = linhaComSplit[0];
                            contato.Email = linhaComSplit[1];
                            contato.NumeroTelefone = linhaComSplit[2];
                            contatosList.Add(contato);
                        }
                    }
                }
            }
            return contatosList;
        }

        public static void EscreverArquivo(List<Contato> contatosList)
        {
            using (StreamWriter sw = new StreamWriter(@FILE_PATH, false))
            {
                foreach (Contato contato in contatosList)
                {
                    string linha = $"{contato.Nome};{contato.Email};{contato.NumeroTelefone}";
                    sw.WriteLine(linha);
                }
                sw.Flush();
            }
        }

    }
}