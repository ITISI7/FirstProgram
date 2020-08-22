using System;

namespace arrayExecrese
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[4] { d, c, b, a };
            

            for (int i=0; i<4; ++i)
            {
                Console.WriteLine(number[i]);
            }
            
        }
            
    }
}
