using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34Structs
{
    internal class Carro
    {
        private List<Dono> antigosDonos;

        public Carro()
        {
            this.antigosDonos = new List<Dono>();
        }

        public void AdicionarAntigoDono(Dono dono)
        {
            antigosDonos.Add(dono);
        }

        public List<Dono> GetAntigosDonos()
        {
            return antigosDonos;
        }
    }


}
