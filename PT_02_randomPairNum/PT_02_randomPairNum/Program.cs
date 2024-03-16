namespace PT_02_randomPairNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int[] arrey = new int[randomNumber.Next(24, 51)];
            int pairCount = 0;

            Console.Write("The numbers are: ");
            for (int i = 0, j = 0; i < arrey.Length; i++)
            {
                j = randomNumber.Next(0, 1001);
                arrey[i] = j;
                if ((arrey[i] % 2) == 0 && arrey[i] != 0)
                    pairCount++;
                if (i < (arrey.Length - 1))
                    Console.Write($"{arrey[i]}, ");
                else Console.Write($"{arrey[i]}.\n");
            }
            Console.WriteLine("_________________\n");
            Console.WriteLine($"The number of pairs: {pairCount}\n" +
                $"They are: ");

            for (int i = 0;i < arrey.Length;i++)
            {
                if ((arrey[i] % 2) == 0 && arrey[i] != 0)
                {
                    if (pairCount > 1)
                        Console.Write($"{arrey[i]}, ");
                    else
                        Console.Write($"{arrey[i]}.\n");
                    pairCount --;
                }

            }
        }
    }
}
