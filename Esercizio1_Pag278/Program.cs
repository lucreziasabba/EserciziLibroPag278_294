using System;
using System.Collections.Generic;

namespace Esercizio1_Pag278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>(n);
            List<int> duplicati = new List<int>();
            for (int i=0; i<n;i++)
            {
                Console.WriteLine("Inserisci un numero");
                int num = int.Parse(Console.ReadLine());
                if (lista.Contains(num))
                {
                    duplicati.Add(num);
                }
                else
                {
                    lista.Add(num);
                }
            }
            foreach (int doppioni in duplicati)
                {
                    Console.WriteLine($"I duplicati sono: {doppioni}");
                }
                Console.ReadLine();
        }
    }
}
