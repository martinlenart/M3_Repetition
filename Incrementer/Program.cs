using System;

namespace Incrementer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;


            int c = ++a * b++;
            
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine();
            int[] array1 = { 1, 2, 3, 4 };
            for (int i = 0; i < array1.Length-1;)
            {
                
                Console.WriteLine(array1[++i]);
                
            }
        }
    }
}
