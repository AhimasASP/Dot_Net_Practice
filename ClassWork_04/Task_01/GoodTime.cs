using System;

namespace Task_01
{
    class GoodTime
    {
        static void Main(string[] args)
        {

            TimeSpan date = DateTime.Now.TimeOfDay;
            int hours = date.Hours; 
            if (9 <= hours &&  hours < 12) Console.WriteLine("Good morning, guys");
            if (12 <= hours &&  hours < 15) Console.WriteLine("Good day, guys");
            if (15 <= hours &&  hours < 22) Console.WriteLine("Good evening, guys");
            if (22 <= hours &&  hours < 9) Console.WriteLine("Good night, guys");
        }
    }
}
