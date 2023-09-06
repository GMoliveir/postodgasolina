    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace Posto_de_Gasolina
{
    class Etanol : Combustivel
    {
        public Etanol (string tipo) :base(tipo) 
        {    
            Preco = 3.50;
        }
        public override string Mostra()
        {
            return base.Mostra() + "Preço: " + Preco;
        }
    }
}