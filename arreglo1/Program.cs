using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int suma = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                suma += valores[i];
            }
            Console.WriteLine("La suma de los valores del arreglo es: {0}", suma);
        }
    }
}
