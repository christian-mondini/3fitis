using System;

namespace Da_decimale_a_binario_Mondini_3_F
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            string b;
            b = "";

            Console.WriteLine( "Inserisci un numero decimale: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                if (n % 2 == 0)
                    b = '0' + b;
                else
                    b = '1' + b;
                n = n / 2;
            }

            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
