using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            Monnaie showmoney = Euro;

            Console.WriteLine($"{x} {showmoney()}");

            showmoney = Dollars;

            Console.WriteLine($"{x} {showmoney()}");
        }





    public delegate string Monnaie();


        public static string Euro()

        {

            return "euro";

        }


        public static string Dollars()

        {

            return "dollars";

        }

    }
}
