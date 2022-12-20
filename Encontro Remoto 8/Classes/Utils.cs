using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Console.Classes
{
    public static class Utils
    {

        public static void ParadaNoConsole(string texto)
        {
            Console.WriteLine(texto);
            Console.ReadLine();//parada no console
        }

        public static void Loading(string texto, int milesegundos, int qtdPontinhos, ConsoleColor corFundo = ConsoleColor.Black, ConsoleColor corFonte = ConsoleColor.White)
        {
            Console.BackgroundColor = corFundo;
            Console.ForegroundColor = corFonte;
            Console.Write($"{texto} ");
            
            for (int i = 1; i <= qtdPontinhos; i++)
            {
                Console.Write($".");
                Thread.Sleep(milesegundos);
            }

            Console.ResetColor();
        }
    }
}