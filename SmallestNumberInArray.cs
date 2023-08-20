namespace SmallLestArray
{
    
    
        //Program to find the largest number in an array using a for loop. (LargestNumberInArray.cs)
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] arr = { 100, 200, 500, 300, 160 };


                int min = arr[0];


                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] < min)
                        min = arr[i];
                }
                Console.WriteLine("Largest Number of array: " + min);
            }
        }
    }

    