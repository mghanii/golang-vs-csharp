using System;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Types in C#");

            /*
           ♦♦ Predefined types ♦♦
              1. Value types: Numeric, bool, char
              2. Reference types: object , string
          */

            // ♦♦ Numeric types ♦♦

            // Signed integer
            sbyte a = -4;  // 8 bits  –27 to 27–1
            short b = 4;   // 16 bits –215 to 215–1
            int c = 4;     // 32 bits –231 to 231–1
            long d = 4;    // var d = 4L;  64 bits –263 to 263–1

            // Unsigned integer
            byte e = 4;    // 8 bits 0 to 28–1
            ushort f = 4;  // 16 bits 0 to 216–1
            uint g = 4;    // var g = 4U;    32 bits 0 to 232–1
            ulong h = 4;   // var h = 4UL;   64 bits 0 to 264–1

            //Real number
            float j = 0.4F; // 32 bits ± (~10–45 to 1038)
            double k = 4D;  // 64 bits ± (~10–324 to 10308)
            decimal l = 4.0M; // 128 bits ± (~10–28 to 1028)

            var m = 4;   // m is int
            var n = 4.0; // n is double

            // ♦♦ Boolean type ♦♦

            bool o = true;

            // ♦♦ Character type ♦♦

            char p = 'A';

            // ♦♦ String type ♦♦

            string s = "str";

            // ♦♦ Array type ♦♦

            char[] alphabet = new char[26];

            // ♦♦ Object type ♦♦
            // 📝 object is the base class for all types so any type can be upcast to object.

            object obj = 4;

            // composite types

            // ♦ class
            // ♦ struct
            // ♦ interface
            // ♦ enum
        }
    }
}