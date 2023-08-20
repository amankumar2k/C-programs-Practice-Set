namespace EvenOrOdd
{
  //  Program to check if a number is even or odd using if-else statement(EvenOdd.cs).
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter The Number");
            a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("The Number Is Even");
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
            }

        }
    }
}