﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra");

            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");

            }
            else if(nota >= 5.0)
            {
                Console.WriteLine("Rcuperação");
            }
            else
            {
                Console.WriteLine("te vejo na próxima");
            }
            Console.WriteLine("Fim!!");
        }
    }
}
