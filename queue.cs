using System;
using System.Collections.Generic;

class Toyota
{
    public static void Main()
    {
        Queue<string> carCollection = new Queue<string>();

        carCollection.Enqueue ("Corolla");
        carCollection.Enqueue ("Camry");
        carCollection.Enqueue ("Yaris");
        carCollection.Enqueue ("Prius");
        carCollection.Enqueue ("C-HR");
        carCollection.Enqueue ("RAV4");
        carCollection.Enqueue ("Sienna");

       // Print the cars in my queue
        Console.WriteLine("Toyota cars as of 10/27/2010:");
        foreach (string car in carCollection)
        {
            Console.WriteLine(car);
        }

        carCollection.Dequeue ();

        Console.WriteLine("\nToyota cars as of 10/28/2020:");
        foreach (string car in carCollection)
        {
            Console.WriteLine(car);
        }
       
    }
}