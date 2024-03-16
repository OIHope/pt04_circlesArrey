namespace PT_03_textSybmolsWthSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var symbSpaces = 0;
            var symbNoSpaces = 0;

            Console.WriteLine("Write here anything: ");
            string givenText = Console.ReadLine();
            while (string.IsNullOrEmpty(givenText))
            {
                Console.WriteLine("You need to write at least ONE symbol!\nTry Again:");
                givenText = Console.ReadLine();
            }

            Console.WriteLine("___________________\n");

            foreach (char i in givenText)
            {
                if (i == ' ')
                    symbSpaces++;
                else
                {
                    symbNoSpaces++;
                    symbSpaces++;
                }
            }

            Console.WriteLine($"Text \"{givenText}\" include: \n" +
                $"- {symbSpaces} symbols with spaces\n" +
                $"- {symbNoSpaces} symbols without spaces");
            Console.WriteLine("________________\n");

        }
    }
}
