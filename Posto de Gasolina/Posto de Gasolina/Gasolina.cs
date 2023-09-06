using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posto_de_Gasolina
{
    internal class Gasolina :Combustivel
    {
        public Gasolina(string tipo) : base(tipo)
        {
            Preco = 5.00;
        }
        public override string Mostra()
        {
            return base.Mostra() + "Preço: " + Preco;
        }
    }
}
