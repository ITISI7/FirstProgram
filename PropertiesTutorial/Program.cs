using System;

namespace PropertiesTutorial
{
    //class TimePeriod
    //{
    //    private int days;
    //    public int Days
    //    {
    //        get
    //        {
    //            return days;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TimePeriod time = new TimePeriod();
    //        Console.WriteLine(time.Days);

    //    }
    //}
    class TimePeriod
    {
        private int days;
        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }
        public int Weeks
        {
            get
            {
                return days / 7;
            }
            set
            {
                days = value * 7;
            }
        }
    }
    class Money
    {
        private float balance;
        public float audBalance
        {
            get
            {
                return balance;
            }
        }
        public float usBalance
        {
            get
            {
                return balance * 0.72f;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            money.audBalance = 40f;
            TimePeriod time = new TimePeriod();
            time.Days = 8;
            Console.WriteLine("Days " + time.Days);
            Console.WriteLine("Weeks " + time.Weeks);

        }
    }
}
