namespace FlipBoolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a;
            
           
            
         //   string value;
            Console.WriteLine("Enter Any Boolean");

            //  value = Console.ReadLine();
            a = Convert.ToBoolean(Console.ReadLine());
            if(a== true)
            {
               a= false;
            }
            else
            {
                a= true; ;
            }
            Console.WriteLine("The Flip Value " +a);

        }
    }
}