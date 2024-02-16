using System;
using System.Collections.Generic;
namespace ListorUppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            Max(lista);

        }

        static void Max(List<int>lista)
        {
            lista.Sort();
            lista.RemoveRange (0, lista.Count -1);
            lista.Remove(1);
        
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}