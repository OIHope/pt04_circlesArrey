namespace PT_04_smthScary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] engAlphabet = new char[26];
            for (int i = 0; i < engAlphabet.Length; i++)
                engAlphabet[i] = (char)(i + 'a');
            foreach (char i in engAlphabet)
                Console.WriteLine($"Letter \"{i}\" ASCII is {(int)i}");
        }
    }
}
