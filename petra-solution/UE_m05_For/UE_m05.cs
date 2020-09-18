using System;

namespace UE_m05_For
{
    class UE_m05
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }


            Console.ReadKey();
        }
    }
}
