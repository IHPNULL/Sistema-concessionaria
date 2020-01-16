using System;
using System.Collections.Generic;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string plac = "vazio";
            int anoModel;
            string marc = "vazio";
            string co = "vazio";
            string model = "vazio";
            double valo = 0;

            List<Veiculo> veiculos = new List<Veiculo>();

                Console.WriteLine("Deseja cadastrar um veiculo?\n1 - SIM\n2 - NÃO");
                int ctr = int.Parse(Console.ReadLine());
                Console.Clear();

            while (ctr == 1)
            {
                if (ctr == 1)
                {
                    Console.Write("Digite a placa: ");
                    plac = Console.ReadLine();

                    Console.Write("\nDigite o ano: ");
                    anoModel = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite a marca: ");
                    marc = Console.ReadLine();

                    Console.Write("\nDigite a cor: ");
                    co = Console.ReadLine();

                    Console.Write("\nDigite o modelo: ");
                    model = Console.ReadLine();

                    Console.Write("\nDigite o valor: ");
                    valo = Double.Parse(Console.ReadLine());

                    veiculos.Add(new Veiculo
                    {
                        Id = i,
                        Placa = plac,
                        AnoModelo = anoModel,
                        Marca = marc,
                        Cor = co,
                        Modelo = model,
                        Valor = valo,
                    });

                        i++;
                }
                Console.Clear();
                Console.WriteLine("Deseja cadastrar um veiculo?\n1 - SIM\n2 - NÃO");
                ctr = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Carros em estoque: ");

            foreach (Veiculo u in veiculos)
            {
                Console.Write("\nID: "+ u.Id + " Modelo: " + u.Modelo + "\n--------------\n");
            }
        }
    }
}