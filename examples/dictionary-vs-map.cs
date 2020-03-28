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

    // check if key is exist

    if (!colors.ContainsKey("Yellow"))
    {
      // adds new key/value pair
      colors.Add("Yellow", "#FFEF00"); // or colors["Yellow"] = "#FFEF00";
    }

    if (!colors.TryGetValue("Yellow", out var _))
    {
      colors.Add("Yellow", "#FFEF00");
    }

    // TryAdd does nothing if key already exist
    if (!colors.TryAdd("Yellow", "#FFEF00"))
    {
      Console.WriteLine("key already exists");
    }
  }
}