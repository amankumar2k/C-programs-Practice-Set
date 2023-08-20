namespace NegOrPosNumber
{
    //Program to check if a number is positive or negative using if-else statement(PostiveNegative.cs).
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num= Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else {
                Console.WriteLine("Number is Negative");
            
            }


        }
    }
}