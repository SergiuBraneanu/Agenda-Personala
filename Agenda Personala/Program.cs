using System;
using System.Collections.Generic;

namespace Agenda_Personala
{
    class Program
    {
        static int Comenzi()
        {
            Console.WriteLine("Alegeti o comanda:");
            Console.WriteLine("1-Afisati agenda");
            Console.WriteLine("2-Intoduceti o persoana noua");
           var c=int.Parse(Console.ReadLine());
            return c;

        }
        static void Main(string[] args)
        {
            int c = 0;
            c = Comenzi();
            if(c==2)
            {

            }
            
        }
    }
}
