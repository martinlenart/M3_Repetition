using System;

namespace M3_Repetition
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
            
            //change content in numbers3 to 10, 15, 12, 3

            //create 5 element in numbers4  5, 2, 3, 4

        }
    }
}
