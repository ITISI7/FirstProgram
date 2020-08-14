using System;
using System.Threading;
using System.Threading.Tasks.Sources;

namespace functionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            game cl = new game();
            cl.Start();
        }

      
    }
    public class game
    {
        static int score = 100;
        private static int result;

        public void Start()
        {
            int result = AddToScore(score);
            Console.WriteLine("Your score is " + score);
            Console.WriteLine("Your score increase it is now " + result);
            Console.ReadKey();
        }
        public static int AddToScore(int add)
        {
            result = score + add;
            return result;
        }
    }
}
