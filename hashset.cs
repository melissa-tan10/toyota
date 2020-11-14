using System;
using System.Collections.Generic;

class Car
{
    static void Main()
    {
        HashSet<String> Sedans = new HashSet<String>();
        HashSet<String> Suvs = new HashSet<String>();

        Sedans.Add ("Corolla");
        Sedans.Add ("Camry");
        Sedans.Add ("Yaris");
        Sedans.Add ("Prius");

        Sedans.Add ("Corolla"); // error, can't add Corolla again

        Suvs.Add ("C-HR");
        Suvs.Add ("RAV4");
        Suvs.Add ("Sienna");

        Console.Write ("Sedans contains {0} elements: ", Sedans.Count);
        DisplaySet (Sedans);

        Console.Write("SUVS contains {0} elements: ", Suvs.Count);
        DisplaySet (Suvs);

        // Create a new HashSet with both sedans and SUVs
        HashSet<String> allCars = new HashSet<String>(Sedans);
        Console.WriteLine ("allCars UnionWith SUVs ...");
        allCars.UnionWith (Suvs);

        Console.Write ("allCars contains {0} elements: ", allCars.Count);
        DisplaySet (allCars);

    }

    private static void DisplaySet (HashSet<String> set)
    {
        Console.Write ("{");
        foreach (String i in set)
        {
                Console.Write (" {0}", i);
        }
        Console.WriteLine (" }");
    }
}