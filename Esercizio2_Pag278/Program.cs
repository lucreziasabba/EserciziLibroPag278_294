using System;
using System.Linq;
using System.Collections.Generic;

namespace Esercizio2_Pag278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>(n);
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                lista.Add(random.Next(1, 1000));
            }
            lista.Sort();
            foreach (int ordine in lista)
            {
                Console.WriteLine($"I numeri in ordine crescente sono: {ordine}");
            }
            Console.ReadLine();
        }
    }
}
