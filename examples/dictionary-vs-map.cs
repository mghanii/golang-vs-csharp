using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // C# generic Dictionary defined in  System.Collections.Generic namespace
    // It uses a hashtable data structure to store keys and values.

    var colors = new Dictionary<string, string>
        {
             {"White","#FFFFFF" }
            ,{"Red","#FF0000" }
            ,{"Green","#0000FF" }
            ,{"Blue","#008000" }
        };

    Console.WriteLine(colors["Red"]); // #FF0000

    // update value of existing key
    colors["White"] = "#FFF";

    // iterate over dictionary

    foreach (var kv in colors)
    {
      Console.WriteLine($"Code of {kv.Key} is {kv.Value}");
    }

    if (!colors.ContainsKey("Yellow"))
    {
      // adds new key/value pair
      colors.Add("Yellow", "#FFEF00"); // or colors["Yellow"] = "#FFEF00";
    }
  }
}