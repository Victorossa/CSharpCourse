using System;

class Program
{
    static void Main1()
    {
        //no use of namespace
        System.Console.WriteLine("Welcome to C# Training");
        //with namespace use
        Console.WriteLine("Welcome to C# Training");
        System.Console.ReadLine();
    }

    static void Main()
    {
        //no use of namespace
        System.Console.WriteLine("Welcome to C # Training for the main method");
        //with namespace use
        Console.WriteLine("Welcome to C# Training");
        Main1();
        System.Console.ReadLine();
        //the system will look for the main method to initialize
        
    }
}

//Basic structure of a C# program
//What is a Namespace
//Purpose of main method (purpose - proposito)

/* the namespace declaration. usingSystem, indicates that you are using 
 the system namespace
 A namespace is used to organize your code and is collection of classes, 
 interfaces, structs, enums, and delegates
 
 Main method is the entry point into your application*/

