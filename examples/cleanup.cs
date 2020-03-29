using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    // "using" statement is used to automatically dispose an object once using statement is exited (by reaching block end or by an exception).
    // The objects specified within the using block must implement the IDisposable interface.
    // IDisposable interface contains Dispose method which can be invoked when object is no longer needed.

    using (var fileStream = File.Open("path/to/file", FileMode.Open))
    {
      // ....
    }

    // this is equivalent to:
    FileStream fs = null;

    try
    {
      fs = File.Open("path/to/file", FileMode.Open);

      // ...
    }
    finally
    {
      if (fs != null)
        fs.Dispose();
    }

    Console.ReadKey();
  }
}