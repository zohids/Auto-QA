using System;

namespace Auto_QA
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int min = 0;
            int max = 28;

            int[] arrays = new int[5];

            Random randarr = new Random();
            
            
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = randarr.Next(min, max);
                
                Console.WriteLine(arrays[i]);
                
            }
            Array.Sort(arrays);
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.Write(arrays[i] + " ");
                //or we can use Console.WriteLine(arrays[i]);
            }

        }
    }
}
