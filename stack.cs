using System; 
using System.Collections.Generic;
using System.Collections;  // For old-style ArrayList
class Toyota
{ 

    static void Main(string[] args) 
    { 
         Stack carStack = new Stack(); 
         carStack.Push ("Sienna"); 
         carStack.Push ("RAV4"); 
         carStack.Push ("C-HR"); 
         carStack.Push ("Prius"); 
         carStack.Push ("Yaris"); 
         carStack.Push ("Camry");
         carStack.Push ("Highlander");  // ... wait a minute ... it was Corolla 
         carStack.Pop ();  // remove Highlander 
         carStack.Push ("Corolla");  // add Corolla to list 
         Console.WriteLine("Contents of Toyota cars:");  

         // print cars
         foreach(string car in carStack) { 
             Console.WriteLine(car); 
          } // foreach   

         Console.WriteLine("\n\nPopping the stack...\n");  // skip a few lines 

         while(carStack.Count > 0) { 
             string car = (string) carStack.Pop (); 
             Console.WriteLine("Popping {0}", car ); 
         }  // while 

    }  // main 

}  // class Stack Sample