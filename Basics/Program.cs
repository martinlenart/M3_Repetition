using System;

namespace Basics
{
    class Program
    {
        public static int[] numbers1 = { 1, 4, 9, 6 };

        static void Main(string[] args)
        {
            int[] numbers2 = new int[20];
            int[] numbers3 = { 1, 4, 9, 6 };
            int[] numbers4 = null;

            Console.WriteLine(numbers1.Length);
            Console.WriteLine(numbers2.Length);
            Console.WriteLine(numbers3.Length);

            if (numbers4 != null)
                Console.WriteLine(numbers4.Length);

            //Alternative to the if statement above
            Console.WriteLine(numbers4?.Length);
            
            if (numbers4?.Length != null)
                Console.WriteLine(numbers4.Length);

            //set 10 numbers in numbers2
            numbers2[0] = 1; numbers2[1] = 2; numbers2[2] = 3; numbers2[3] = 4;
            numbers2[4] = numbers2[5] = numbers2[6] = numbers2[7] = 1;
            numbers2[8] = 14;
            numbers2[9] = 5;

            //change content in numbers3 to 10, 15, 12, 3
            numbers3[0] = 10; numbers3[1] = 15;
            numbers3[2] = 12; numbers3[3] = 3;
            numbers3 = new int[] { 10, 15, 12, 3 };

            //create 4 element in numbers4  5, 2, 3, 4
            numbers4 =  new int[]{ 1, 4, 9, 6 };

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.Write($"{numbers1[i]}, ");
                if (numbers1[i] == 9)
                    Console.WriteLine("Hit number 9");
            }

            foreach (var item in numbers2)
            {
                Console.Write($"{item}, ");
                if (item == 14)
                    Console.WriteLine("Hit number 14");
            }
        }
    }
}
