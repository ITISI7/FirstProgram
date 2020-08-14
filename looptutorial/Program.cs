using System;

namespace looptutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            //int count = 0;
            //while(count < 3)
            //{
            //    count++;
            //    Console.WriteLine("The loop has run " + count + " times.");
            //}
            for(int count = 0; count < 3; count++)
            {
                Console.WriteLine("The loop has run " + count + " times.");
                // how to break
                //if(count == 2)
                //{
                //    break;
                //}
            }
            Console.WriteLine("The loop is finshed");
            Console.ReadKey();

        }
    }
}
