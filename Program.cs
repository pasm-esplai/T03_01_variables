using System;

namespace T03_01_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 25;
            int val2 = 30;

            int suma = val1 + val2;
            int resta = val1 - val2;
            int pdto = val1 * val2;
            int div = val1 / val2;
            int mod = val1 % val2;

            Console.WriteLine("Suma: " + val1 + " + " + val2 + " = " + suma);
            Console.WriteLine("Resta: " + val1 + " - " + val2 + " = " + resta);
            Console.WriteLine("Producto: " + val1 + " * " + val2 + " = " + pdto);
            Console.WriteLine("División: " + val1 + " / " + val2 + " = " + div);
            Console.WriteLine("Resto: " + val1 + " % " + val2 + " = " + mod);
        }
    }
}
