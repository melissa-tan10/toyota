using System;
using System.Collections.Generic;

namespace Cars
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a dictionary in which both keys and values are strings.
      Dictionary<string, string> dict = new Dictionary<string, string>();

      // Add some items to the dictionary: each has a key and a value.
      dict.Add ("Corolla", "19600");
      dict.Add ("Camry", "24425");
      dict.Add ("Yaris", "15600");
      dict.Add ("Prius", "24325");
      dict.Add ("C-HR", "21295");
      dict.Add ("RAV4", "25950");
      dict.Add ("Sienna", "31640");

      // Iterate the dictionary's contents with foreach.
      // Note that you're iterating pairs of keys and values,
      // using the KeyValuePair<t,u> type.
      Console.WriteLine ("\nToyota cars:");
      foreach (KeyValuePair<string, string> pair in dict)
      {
            // Because the key is a string, you can use string methods
            Console.WriteLine ("Model: " + pair.Key.PadRight(8) + "  Price: $" + pair.Value);
      }


    }
  }
}