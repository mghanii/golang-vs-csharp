using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
        // explicit
        int a = 9;

        // implicit
        var b = 9;

        // multiple variables declaration at once
        int c, d, e;
        int x = 1, y = 2, z = 3;

        // Constant (unchangeable and read-only)
        const int i = 7;

        // 📝 Local variables can't be used before assigning them.
        // 📝 Constant variable must be assiged a value at the time of its declaration
    }
  }
}