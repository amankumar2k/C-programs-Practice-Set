using System.Transactions;

namespace SwichCalculator
{
   // Program to Calculate the Sum, Multiplication, Division and Subtraction of Two Numbers using switch (Calculator.cs)

    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a, b;
            Console.WriteLine("Enter First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" press -1 : For Sum Of Two Numbers");
            Console.WriteLine(" press -2 : For Multiplication Of Two Numbers");
            Console.WriteLine(" press -3 : For  Division Of Two Numbers");
            Console.WriteLine(" press -4 : For Subtraction Of Two Numbers");

            
            int s = Convert.ToInt32(Console.ReadLine());

            switch (s)
            {
                case 1:
                    Console.WriteLine("The Sum Of  Two Numbers :" +(a + b));
                    break;
                    case 2:
                    Console.WriteLine("The Multiplication Of  Two Numbers :" + (a * b));
                    break;
                case 3:
                    Console.WriteLine(" The Division Of  Two Numbers :" + (a / b));
                    break;
                    case 4:
                    Console.WriteLine("The Subtraction Of  Two Numbers :"+(a - b));
                    break;  
                    default: Console.WriteLine("Enter Valaid Input");
                    break;
                    
            }


        }
    }
}