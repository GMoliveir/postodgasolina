using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Posto_de_Gasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etanol etanol = new Etanol("Etanol");
            Gasolina gasolina = new Gasolina("Gasolina");
            Diesel diesel = new Diesel("Diesel");

            do
            {
                Console.WriteLine("Selecione o combustível desejado:");
                Console.WriteLine("1. Etanol");
                Console.WriteLine("2. Gasolina");
                Console.WriteLine("3. Diesel");
                Console.WriteLine("4. Sair");

                Console.Write("Opção: ");
                int op = int.Parse(Console.ReadLine());

                if (op == 4)
                {
                    Console.WriteLine("Opção Invalida:....");
                    break;
                }

                Console.Write("Digite a quantidade de Litros:.... ");
                int quantidadeLitros = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        double valorTotalEtanol = quantidadeLitros * etanol.Preco;
                        Console.WriteLine("Valor total:...R$ " + valorTotalEtanol);
                        break;

                    case 2:
                        double valorTotalGasolina = quantidadeLitros * gasolina.Preco;
                        Console.WriteLine("Valor total:...R$ " + valorTotalGasolina);
                        break;

                    case 3:
                        double valorTotalDiesel = quantidadeLitros * diesel.Preco;
                        Console.WriteLine("Valor total:...R$ " + valorTotalDiesel);
                        break;

                    default:
                        Console.WriteLine("Opção inválida:...");
                        continue;
                }
            } while (true);

            Console.ReadKey();
        }
    }
}