namespace LoopSum
{
   // Program to calculate the sum of numbers from 1 to 100 using a for loop.(SumOfARange.cs)
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,  sum = 0;
            Console.WriteLine("");
            for(i=1;i<=100; i++)
            {
                sum = sum+i;

            }
            Console.WriteLine(sum);
        }
    }