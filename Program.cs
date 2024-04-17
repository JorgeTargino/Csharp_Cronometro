﻿using System;
using System.Threading;

namespace Program
{
    class Stopwacth
    {
        static void Main(string[] args) 
        {
            //Start(6);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            //Console.WriteLine("Escolha a opção desejada...");
            Console.WriteLine("S = Segundo => 10s =  10 segundo ");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar...");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
              multiplier = 60;

            if (time == 0)
              System.Environment.Exit(0);

            PreStart(time * multiplier);
                
        }


        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            
            Start(time);
        }
        static void Start(int time)
        {
            
            int currentTime = 0;

            while (currentTime != time) 
            {
               Console.Clear();
               currentTime++;
               Console.WriteLine(currentTime);
               Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwacth finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}