namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            Sum1(num);
            

        }

        static int Sum1(int num)
        {
            int sum = 0;
            for (int i = 2; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of even numbers:" + sum);
            return num;
        }


        ////Bu zaman Main-de Sum1 metodumuzu Sum2 metoduna deyisirik.
        //static void Sum2(int num)
        //{
        //    int sum = 0;
        //    for (int i = 2; i < num; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            sum += i;
        //        }
        //    }

        //    Console.WriteLine("Sum of even numbers:" + sum);
      
        //}
    }
}