using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listening");

        string userResponse = Console.ReadLine();
        int userInput = int.Parse(userResponse);

        if (userInput == 1)
        {
            Breathing breathing = new Breathing();
            breathing.StartActivity();
        }
        else if (userInput == 2)
        {
            Reflect reflect = new Reflect();
            reflect.StartActivity();
        }
        else if (userInput == 3)
        {
            Listening listening = new Listening();
            listening.StartActivity();
        }
        else
        {
            Console.WriteLine("Sorry, that isn't an option, please try again");
        }
    }
}