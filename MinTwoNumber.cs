namespace MinOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a <b)
            {
                Console.WriteLine("minimum Number is :" + a);
            }
            else
            {
                Console.WriteLine("minimum number is :" + b);

            }
        }
    }
}