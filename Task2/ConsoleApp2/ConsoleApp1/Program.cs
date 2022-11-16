namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Enter word :");
            word = Console.ReadLine();
            string sentences = "";
            sentences=NoSpaceWord(word);

        }
        static string NoSpaceWord(string word)
        {
            string lastword;
            lastword = word.Replace(" ", string.Empty);
            Console.WriteLine(lastword);
            return lastword;
        }
    }
}