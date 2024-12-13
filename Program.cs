using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CRONOMETRO");
            Console.WriteLine("S = Segundo Ex.: 10s = 10 segundos");
            Console.WriteLine("M = Minuto Ex.: 10m = 10 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
                        
            string data = Console.ReadLine().ToLower();

            if (data == "0")
                Sair();

            char type = char.Parse(data.Substring((data.Length -1), 1));
            int time = int.Parse(data.Substring(0, (data.Length -1)));

            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
            
            Start(time);
        }

        static void Start(int time){
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.Write(currentTime);
                Thread.Sleep(1000);
            }
            Console.WriteLine("");
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2000);
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Saindo...");
            System.Environment.Exit(0);
        }

    }
}