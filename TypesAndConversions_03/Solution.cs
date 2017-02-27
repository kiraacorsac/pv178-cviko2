using System;

namespace TypesAndConversions_02
{
    public static class Solution
    {
        public enum Color { Red, Green, Blue }

        /// <summary>
        /// Prevod Enum na string a zpet:
        /// je zadan nasledujici vyctovy typ: public enum Color {Red, Green, Blue} 
        /// dale jsou zadany nasledujici hodnoty:
        /// var colorString = "Green";
        /// var color = Color.Green;
        /// ukolem je prevest nejprve promenou colorString na Enum a nasledne color na String
        /// Tip: lze vyuzit funkcionality staticke tridy Enum
        /// </summary>
        public static void Task01()
        {

        }

        /// <summary>
        /// prevod int (Int32) na Hexadecimalni hodnotu a zpet
        /// jsou zadany nasledujici hodnoty:
        /// int intValue = 1234;
        /// string hexValue = "4D2"; // hexadecimalni hodnota cisla 1234
        /// ukolem je prevest celociselnou hodnotu na hexadecimalni string a naopak,
        /// po prevodu provedte porovnani zda prevedena hodnota odpovida ocekavanemu vysledku
        /// a vysledek vypiste na konzoli
        /// Tip: pro prevod z hexadecimalni hodnoty na celociselnou lze pouzit vhodnou variantu metody tridy Convert,
        /// pro opacny prevod by se mohlo hodit: https://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx
        /// </summary>
        public static void Task02()
        {

        }
    }
}
