using System;
using System.Collections.Generic;

public class Lists
{
    static void Main()
    {

        List<string> carList = new List<string>();

        carList.Add("Corolla");
        carList.Add("Camry");
        carList.Add("Yaris");
        carList.Add("Prius");
        carList.Add("C-HR");
        carList.Add("RAV4");
        carList.Add("Sienna");

        Console.WriteLine("\nToyota cars: ");
        foreach (string car in carList)
        {
            Console.WriteLine(car);
        }

    }  // main


}  // public class lists