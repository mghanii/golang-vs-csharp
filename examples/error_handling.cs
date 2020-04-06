using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    // All exceptions in c# inherits from System.Exception class

    string filePath = null;
    FileStream stream = null;

    try
    {
      // try block contains the code causing exception

      stream = File.Open(filePath, FileMode.Open);

      //...
    }
    catch (ArgumentException ex) // handles exceptions of type ArgumentException
    {
      Console.WriteLine($"ArgumentException: {ex.Message}");
    }
    catch (Exception ex) // handles any exception
    {
      Console.WriteLine(ex.Message);
    }
    finally
    {
      // will always execute whether an exception is thrown or not.

      if (stream != null)
        stream.Close();
    }
    Console.ReadKey();
  }
}