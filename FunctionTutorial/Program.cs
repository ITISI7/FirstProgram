using System;

namespace FunctionTutorial
{
    class Program
    {
        //static int playerHealth = 100;
        //static int monsterDamage = 30;
        //static void MonsterEncounter()
        //{
        //    Console.WriteLine("A monster appears");
        //    Console.ReadKey();
        //}
        //static void Start()
        //{
        //    Console.WriteLine("The game had began");
        //    Console.ReadKey();
        //    MonsterEncounter();
        //    MonsterAttacks();
        //    MonsterAttacks();
        //    MonsterAttacks();

        //}
        //static void MonsterAttacks()
        //{
        //    playerHealth -= monsterDamage;
        //    Console.WriteLine("The monster attacks you for " + monsterDamage +
        //        " points of damage, you have " + playerHealth + " health left");
        //    Console.ReadKey();
        //}
        //static void Main(string[] args)
        //{
        //    Start();
        //}

        static int numberOne = 10;
        static int numberTwo = 200;
        static void Start()
        {
            int biggestNumber = ReturnBiggestNumber(numberOne, numberTwo);
            Console.WriteLine("Of " + numberOne + " and " + numberTwo + " the biggest number is " +
                biggestNumber);
           
            Console.ReadKey();
        }
        static int ReturnBiggestNumber(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main()
        {
            Start();
        }
    }
}

