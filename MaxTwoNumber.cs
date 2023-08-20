namespace MaxOfTwo
{
    //Program to find the maximum of two numbers using if-else statement(MaxTwoNumber.cs).
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("maximum Number is :" + a);
            }
            else
            {
                Console.WriteLine("maximum number is :" + b);

            }

        }
    }
}