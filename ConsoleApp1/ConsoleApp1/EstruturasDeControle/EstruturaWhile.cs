﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("insira seui palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.ResetColor();
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Tentativas Restantes {0}", tentativasRestantes);
                }
            }


        }
    }
}
