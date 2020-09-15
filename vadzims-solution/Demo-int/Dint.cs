using System;

namespace Demo_int
{
    class Dint
    {
        static void Main(string[] args)
        {
            // Literals for int

            int i1 = 2;
            Console.WriteLine("i1: {0}", i1);

            // int i2 = 2.2; // geht nicht, weil es ein double-Literal ist

            int i3 = 0b00000001;
            Console.WriteLine("i3: {0}", i3);

            int i4 = 0b0000_0011;
            Console.WriteLine("i4: {0}", i4);

            int i5 = 0xFFFF;
            Console.WriteLine("i5: {0}", i5);

            // int i6 = 0o0001; // es gibt kein Literal für Oktalzahlen
            // stattdessen: Convert.ToInt32("12", 8)


            // ============================================
            // default-Wert
            int i0;
            // Console.WriteLine("i0: {0}", i0); // geht nicht, weil kein Wert bei i0
            i0 = default;
            Console.WriteLine("i0: {0}", i0); // 


            // ============================================
            // Min & Max & Overflow      
            Console.WriteLine("int.MinValue: {0}", int.MinValue);
            Console.WriteLine("int.MaxValue: {0}", int.MaxValue);

            unchecked
            {
                int i7 = 2_147_483_647 + 1; // overflow at compile time in checked mode
                Console.WriteLine("i7: {0}", i7); // -2147483648
            }


            // ============================================
            // Casting
            // string zu int
            // int.Parse("4");

            // double zu int
            // cast-Operator ()
            double dbl = 4.9;
            int i8 = (int)dbl;
            Console.WriteLine("i8: {0}", i8); // 4


            Console.ReadKey();
        }
    }
}
