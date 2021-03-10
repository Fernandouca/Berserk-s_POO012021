using System;

namespace Contadores_y_acumuladores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            
            Console.WriteLine("\n.:Bienvenido:.\n");
            Console.Write("inserte un valor para a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("inserte un valor para b: ");
            b = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"Sumando {a} + {b} es igual a {AddNumbers(a,b)} ");
        }
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}