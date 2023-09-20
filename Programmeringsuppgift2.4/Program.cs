using System;
using System.Diagnostics.Metrics;

namespace övning2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar person 1? (kr/h)");
            float lön1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar person 2? (kr/h)");
            float lön2 = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Hur mycket tjänar person 3? (kr/h)");
            float lön3 = float.Parse(Console.ReadLine());
            float medellön = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medellönen för företagets personal är " + medellön + "kr per timme");
            Console.ReadKey();
        }
    }
}