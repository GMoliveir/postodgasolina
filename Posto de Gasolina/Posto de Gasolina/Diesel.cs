using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posto_de_Gasolina
{
    internal class Diesel: Combustivel
    {
        public Diesel(string tipo) : base(tipo)
        {
            Preco = 4.50;
        }
        public override string Mostra()
        {
            return base.Mostra() + "Preço: " + Preco;
        }
    }
}
