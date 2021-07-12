using System;

namespace CAEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var month in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month), month)}");
            }

            foreach (var month in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{month.ToString()} = {(int)month}");
            }

            Console.WriteLine(Month.JAN);
            Console.ReadKey();
        }
    }

    enum Month
    {
        JAN = 1,
        FEB,
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    } 
   

}
