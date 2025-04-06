using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        
        List<Card> Player1 = new List<Card>();
        List<Card> Player2 = new List<Card>();
        List<Card> Stack = new List<Card>();
        List<Card> DiscardPile = new List<Card>();

        Card y8= new Card("8", "yellow");
        Stack.Add(y8);
        Card r9 = new Card("9", "red");
        Stack.Add(r9);
        Card b6 = new Card("6", "blue");
        Stack.Add(b6);
        Card g11 = new Card("11", "green");
        Stack.Add(g11);
        Card y1 = new Card("1", "yellow");
        Stack.Add(y1);
        Card r2 = new Card("2", "red");
        Stack.Add(r2);
        Card b3 = new Card("3", "blue");
        Stack.Add(b3);
        Card r4 = new Card("4", "green");
        Stack.Add(r4);
        Card g4 = new Card("15", "green");
        Stack.Add(g4);
        Card r5 = new Card("5", "red");
        Stack.Add(r5);
        Card y7 = new Card("7", "yellow");
        Stack.Add(y7);
        Card b9 = new Card("9", "blue");
        Stack.Add(b9);
        Card r10 = new Card("10", "red");
        Stack.Add(r10);
        Card y3 = new Card("3", "yellow");
        Stack.Add(y3);
        Card r6 = new Card("6", "red");
        Stack.Add(r6);
        Card b2 = new Card("2", "blue");
        Stack.Add(b2);
        Card y5 = new Card("5", "yellow");
        Stack.Add(y5);
        Card b1 = new Card("1", "blue");
        Stack.Add(b1);
        Card r8 = new Card("8", "red");
        Stack.Add(r8);
        Card y9 = new Card("9", "yellow");
        Stack.Add(y9);
        Card g3 = new Card("3", "green");
        Stack.Add(g3);
        Card r3= new Card("3", "red");
        Stack.Add(r3);
        Card b5= new Card("5", "blue");
        Stack.Add(b5);
        Card g5= new Card("5", "green");
        Stack.Add(g5);
        Card y6= new Card("6", "yellow");
        Stack.Add(y6);
        Card r1= new Card("1", "red");
        Stack.Add(y8);
        Card b8= new Card("8", "blue");
        Stack.Add(b8);


        for (int i = 0; i < 7; i++) 
        {
            Draw(Stack, Player1);
            Draw(Stack, Player2);
        }
        Draw(Stack, Player1);
        Draw(Stack, Player2);
        
         Console.WriteLine("Player1");
        for (int i = 0; i < Player1.Count; i++) 
        {
           Console.WriteLine(Player1[Player1.Count - 1].icon + Player1[Player1.Count - 1].color);
        }

        while (Player1.Count != 0 || Player2.Count != 0){
            
       }
    }
    public static void Draw(List<Card> Stack, List<Card> Player){
        Card copy=  Stack[Stack.Count - 1];
        Player.Add(copy);
        Stack.RemoveAt(Stack.Count - 1);
    }
    
}