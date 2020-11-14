  using System;
  using System.Collections.Generic;

  public class GenericCollection  {

       public class CarItem
       {
            public CarItem (string name, string comment)
            {
                  _name = name;
                  _comment = comment;
            }

           private string _name = "";
            private string _comment = "";

           public string Name
            {
                      get {return (_name);}
                      set {_name = value;}
             }

           public string Comment
            {
                      get {return (_comment);}
                      set {_comment = value;}
            }
       } // class CarItem

      public static void Main()  {

      // Create a new LinkedList object
       LinkedList<CarItem> carList = new LinkedList<CarItem>( );

      // Create CarItem objects to add to the linked list
       CarItem i1 = new CarItem ("Corolla", "19600");
       CarItem i2 = new CarItem ("Camry", "24425");
       CarItem i3 = new CarItem ("Yaris", "15600");
       CarItem i4 = new CarItem ("Prius", "24325");
       CarItem i5 = new CarItem ("C-HR", "21295");
       CarItem i6 = new CarItem ("RAV4", "25950");
       CarItem i7 = new CarItem ("Sienna", "31640");
       

       // Add the items
       carList.AddFirst (i1);
       carList.AddFirst (i2);
       carList.AddBefore (carList.Find (i1), i6);
       carList.AddBefore (carList.Find (i1), i3);
       carList.AddAfter (carList.Find (i1), i4);
       carList.AddLast (i5);
       carList.AddLast (i7);

       Console.WriteLine ("\nMotorTrend rankings:\n");

      // Display all items
       foreach (CarItem mvi in carList)
       {
              Console.WriteLine (mvi.Name + " - Price: $" + mvi.Comment);
       }

      Console.WriteLine ("\nDisplay information from the second node in the linked list:\n");

       Console.WriteLine ("carList.First.Next.Value.Name == "
                                            + carList.First.Next.Value.Name);

      Console.WriteLine ("\nDisplay information from the next to last node in the linked list:\n");

       Console.WriteLine ("carList.Last.Previous.Value.Name == "
                                           + carList.Last.Previous.Value.Name);
      } // Main

}  // class GenericCollection