namespace PrimeNumber.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, i, count = 0;

 

            Console.Write("Input  a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0 && n != 1)
                Console.Write("Number Is Prime", n);
            else
                Console.Write("Number Is Not prime number", n);
        }

    }
}