using System;

namespace D_M08_Classes
{
    public class Types
    {
        // _type_ _identifier_ = _wert_;

        // Datentypen:
        // primitive
        int i1 = 1;

        // === komplexe ===
        // Arrays
        int[] intArr = new int[2];
        string[] stringArr = { "d", "t" };

        // Tupel
        (int, string) intStringTupel = (3, "f");

        // enums


        // Value-Typen
        // default - 0;
        public static string ZeigeCharDefault(char arg)
        {
            //arg = default;
            //if (arg is null) // geht nicht, weil char is non-nullable
            //    return "Es ist null";
            //else
            // return arg ?? arg.ToString(); // ?? kann nicht bei char angewendet werden
            return arg.ToString();
        }


        // Referenztypen
        // string und object sind Referenztypen, default Wert ist null

        public static string ZeigeReferenz()
        {
            int[] arr1 = { 1, 3 };
            int[] arr2 = arr1;
            arr1[1] = 4; //
            return arr2[1].ToString(); // ändert man ein Element durch arr1, wird dieses Element auch im arr2 geändert

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
Obwohl string ein Referenztyp ist (default-Wert = null), kriegt man beim Vergleich auch ein True:
{str1 == str2}"; // True

        }

    }
}
