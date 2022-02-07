using System;

namespace StringInterpolation
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"{$"{today:MMMM} {today:dd}, {today:yyyy}",40}");
            Console.WriteLine($"{today:yyyy}.{today:MM}.{today:dd}");
            Console.WriteLine($"Day {today:dd} of {today:MMMM}, {today:yyyy}");
            Console.WriteLine($"Year: {today:yyyy}, Month:{today:MM}, Day:{today:dd}");
            Console.WriteLine($"{today,10:dddd}");
            Console.WriteLine($"{today,10:hh:mm tt}{today,10:dddd}");
            Console.WriteLine($"h:{today:hh}, m:{today:mm}, s:{today:ss}");
            Console.WriteLine($"{today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");
            var pi = Math.PI;
            Console.WriteLine($"{pi:C}");
            Console.WriteLine($"{pi,10:F3}");
        }
    }
}