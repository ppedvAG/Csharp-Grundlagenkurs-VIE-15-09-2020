using System;

namespace Ü_M05_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ü-M05-For-Loop");
            Console.WriteLine("alle Zahlen ausgeben, die durch 4 ohne Rest teilbar sind");
            Console.WriteLine("Ab welche Zahl?:");
            int floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Bis welche Zahl?: ");
            int ceiling = int.Parse(Console.ReadLine());
            for(int i = floor; i < ceiling; i++)
            {
                if (i%4==0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
