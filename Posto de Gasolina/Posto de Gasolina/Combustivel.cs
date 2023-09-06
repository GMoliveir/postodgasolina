using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Posto_de_Gasolina
{
    // Classe mãe para posto de combustivel, recebe a classe Combustivel
    internal class Combustivel
    {
        private string tipo;
        private double preco;

        public string Tipo { get => tipo; set => tipo = value; }
        public double Preco { get => preco; set => preco = value; }

        public Combustivel(string tipo)
        {
            this.Tipo = tipo;
        }

        public virtual string Mostra()
        {
            return $"Tipo: {Tipo}, Preço: {Preco}";
        }
    }
}