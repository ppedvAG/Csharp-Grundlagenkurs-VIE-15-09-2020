using System;

namespace Demo_Classes
{
    public class Types
    {
        //_type_ _identifier_ = _wert_;

        // Datentypen:
        // primitive Datentypen
        int i1 = 1;

        // === komplexe Datentypen ===
        // Arrays
        int[] intArr = new int[2];
        string[] stringArr = { "s", "t" };

        // Tubel
        (int, string) intStringTubel = (3, "vier");

        // enums


        // Value-Typen
        // default = 0
        public static string ZeigeCharDefault (char arg)
        {
            //arg = default;
            //if (arg is null)
            //    return "Es ist null";
            //else
                return arg.ToString(); 
        }

        // Referenztypen
        // string und object sind Referenztypen, default Wert ist Null

        public static string ZeigeReferenz()
        {
            int[] arr1 = { 1, 3 };
            int[] arr2 = arr1;
            arr1[1] = 4; // auch arr2 jetzt [1] = 4 --> JA // Ändert man ein Element durch Arr1 wird dieses Element auch in Arr2 geändert
            return arr2[1].ToString();
        }

        public static string ZeigeReferenzVergleich()
        {
            int[] arr1 = { 1, 3 };
            int[] arr2 = { 1, 3 };
            return (arr1 == arr2).ToString(); // False
        }

        public static string ZeigeStringVergleich()
        {
            string str1 = "{ 1, 3 }";
            string str2 = "{ 1, 3 }";
            return $@"
Obwohl string ein Referenztyp ist (default-Wert = null), bekommt man beim Vergleich auch ein True:
{str1 == str2}"; //True
        }


        // static int[] arr1 = { 1, 3 };
        // int[] arr2 = arr1;







    }
}
