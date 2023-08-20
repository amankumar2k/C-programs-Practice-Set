namespace Factorial


{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, i, Factorial = 1;
            Console.WriteLine("enter n");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Factorial = Factorial * i;

            }
            Console.WriteLine("factorial is: " + Factorial);
            Console.ReadKey();
        }
    }
}