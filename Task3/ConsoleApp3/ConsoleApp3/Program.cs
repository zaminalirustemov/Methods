namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string str = Console.ReadLine();
            string capital = "";
            capital = CapitalLetter(str);
            Console.Write("The Capital Letters : " + capital);

        }

        static string CapitalLetter(string input)
        {
            string caplet = "";
            caplet += input[0];
            caplet += " ";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == ' ')
                {
                    caplet += input[i + 1];
                    caplet += " ";
                }
            }
            return caplet;
        }
    }
}