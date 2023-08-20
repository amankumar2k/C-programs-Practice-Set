 SumOfArray
{
    //Program to sum an array using a for loop.(SumOfAnArray.cs)
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n, sum = 0;
            Console.WriteLine("input the number stored in array");
           n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("element stored in array" + n);
           
            
            for(int i =0; i<n;i++)
            {
              //  Console.WriteLine(i);
                a[i]= Convert.ToInt32(Console.ReadLine());
                
                
            }
            for (int i = 0; i<n;i++)
            {
                sum = sum + a[i];
                
            }
            Console.WriteLine("the sum of array " + sum);

        }
    }
}

// by foreach
//  public static void Main()
//{
//    int[] array = { 1, 2, 3, 4, 5 };

//    int sum = 0;
//    foreach (int num in array)
//    {
//        sum = sum + num ;
//    }

//    Console.WriteLine(sum);
