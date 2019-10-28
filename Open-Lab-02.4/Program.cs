using System;

namespace Open_Lab_02._4
{
    class Program
    {
        public static int GetLegsCount(int chickens, int cows, int pigs)
        {
            return (chickens * 2 + cows * 4 + pigs * 4);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of cows");
            int chickenlegs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the count of chickens");
            int cowslegs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the count of pigs");
            int pigslegs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetLegsCount(chickenlegs, cowslegs, pigslegs));
            


        }
    }
}
