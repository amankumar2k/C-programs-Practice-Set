namespace SumOfTWo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b , sum=0;
            Console.WriteLine("enter the first number: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b= Convert.ToInt32(Console.ReadLine());
            
            sum = a + b;
            Console.WriteLine("the sum of given number: " + sum);
        }
    }
}