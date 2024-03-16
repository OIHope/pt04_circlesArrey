using System;

namespace PT_01_step2Arrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];

            for (int i = 0, j = 2; i < array.Length; i++, j += 2)
                array[i] = j;

            foreach (int i in array)
                Console.WriteLine(i);

            Console.WriteLine("__________________________\n");
            Console.WriteLine($"Arrey length: {array.Length}");
        }
    }
}
