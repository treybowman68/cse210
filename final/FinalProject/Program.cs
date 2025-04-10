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
        Console.WriteLine("Player2");
        for (int i = 0; i < Player2.Count; i++) 
        {
           Console.WriteLine(Player2[Player1.Count - 1].icon + Player2[Player2.Count - 1].color);
        }
        while (Player1.Count != 0 || Player2.Count != 0){
            
       }
    }

    static void shuffleList(List<Card> list){
        Random rng = new Random();
        int n = list.Count;
        while (n > 1) {
            n--;
            int k = rng.Next(n + 1);
            Card value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    static void moveCard(List<Card> from, int fromIndex, List<Card> to){
        to.Add{from[fromIndex]};
        from.RemoveAt(fromIndex);
    }
    static void atartgame(){
        generateDeck();
        shuffleList(mainDeck);

        int count =7;
        while(count > 0){
            moveCard(mainDeck, 0, Player1);
            count --;
        }
        count = 7;
        while(count > 0){
            moveCard(mainDeck, mainDeck.Count()-1, Player2);
    }
    
    moveCard(mainDeck, mainDeck.Count()-1, Discard);

    Console.WriteLine("Main Deck -");
    foreach(Card i in mainDeck){
        i.display();
    }
    Console.WriteLine();

    Console.WriteLine("Player 1's Starting Hand -");
    foreach(Card i in Player1){
        i.display();
    }
    Console.WriteLine();

        Console.WriteLine("Player 2's Starting Hand -");
    foreach(Card i in Player2){
        i.display();
    }
    }

    while( player1.Count() != 0 && player2.Count != 0){
        startTurn(player1, 1);
    }

    static void StartTurn(List<Card> hand, int player){
        int count = 1;
        foreach(Card i in hand){
            Console.Write(count+" - ")
            Console.WriteLine(i.display());
            count++;
        }
    
    Console.WriteLine("The card is"+Discard[Discard.Count()-1].display());

    if(player == 1){
        Console.WriteLine("Your opponent has"+Player2.Count()+" cards left");
    }
    else if(player == 1){
        Console.WriteLine("Your opponent has"+Player1.Count()+" cards left");
    }
    }

    public static void Draw(List<Card> Stack, List<Card> Player){
        Card copy=  Stack[Stack.Count - 1];
        Player.Add(copy);
        Stack.RemoveAt(Stack.Count - 1);
    }
    public static void Deck (List<Card> Stack){
        BasicCard b1= new BasicCard("1", "blue");
        Stack.Add(b1);
        BasicCard b2= new BasicCard("2", "blue");
        Stack.Add(b2);
        BasicCard b1= new BasicCard("3", "blue");
        Stack.Add(b3);
        BasicCard b5= new BasicCard("4", "blue");
        Stack.Add(b4);
        BasicCard b5= new BasicCard("5", "blue");
        Stack.Add(b5);
        BasicCard b6= new BasicCard("6", "blue");
        Stack.Add(b6);
        BasicCard b7= new BasicCard("7", "blue");
        Stack.Add(b7);
        BasicCard b8= new BasicCard("8", "blue");
        Stack.Add(b8);
        BasicCard b9= new BasicCard("9", "blue");
        Stack.Add(b9);
        
        BasicCard y1= new BasicCard("1", "yellow");
        Stack.Add(y1);
        BasicCard y2= new BasicCard("2", "yellow");
        Stack.Add(y2);
        BasicCard y1= new BasicCard("3", "yellow");
        Stack.Add(y3);
        BasicCard y5= new BasicCard("4", "yellow");
        Stack.Add(y4);
        BasicCard y5= new BasicCard("5", "yellow");
        Stack.Add(y5);
        BasicCard y6= new BasicCard("6", "yellow");
        Stack.Add(y6);
        BasicCard y7= new BasicCard("7", "yellow");
        Stack.Add(y7);
        BasicCard y8= new BasicCard("8", "yellow");
        Stack.Add(y8);
        BasicCard y9= new BasicCard("9", "yellow");
        Stack.Add(y9);

        BasicCard r1= new BasicCard("1", "red");
        Stack.Add(r1);
        BasicCard r2= new BasicCard("2", "red");
        Stack.Add(r2);
        BasicCard r1= new BasicCard("3", "red");
        Stack.Add(r3);
        BasicCard r5= new BasicCard("4", "red");
        Stack.Add(r4);
        BasicCard r5= new BasicCard("5", "red");
        Stack.Add(r5);
        BasicCard r6= new BasicCard("6", "red");
        Stack.Add(r6);
        BasicCard r7= new BasicCard("7", "red");
        Stack.Add(r7);
        BasicCard r8= new BasicCard("8", "red");
        Stack.Add(r8);
        BasicCard r9= new BasicCard("9", "red");
        Stack.Add(r9);
        
        BasicCard g1= new BasicCard("1", "green");
        Stack.Add(g1);
        BasicCard g2= new BasicCard("2", "green");
        Stack.Add(g2);
        BasicCard g1= new BasicCard("3", "green");
        Stack.Add(g3);
        BasicCard g5= new BasicCard("4", "green");
        Stack.Add(g4);
        BasicCard g5= new BasicCard("5", "green");
        Stack.Add(g5);
        BasicCard g6= new BasicCard("6", "green");
        Stack.Add(g6);
        BasicCard g7= new BasicCard("7", "green");
        Stack.Add(g7);
        BasicCard g8= new BasicCard("8", "green");
        Stack.Add(g8);
        BasicCard g9= new BasicCard("9", "green");
        Stack.Add(g9);

        Skip redS1 = new Skip("red", "S");
        mainDeck.Add(redS1);
        Skip redS2 = new Skip("red", "S");
        mainDeck.Add(redS2);
        Reverse RedR1 = new Reverse("red", "R");
        mainDeck.Add(RedR1);
        Reverse RedR2 = new Reverse("red", "R");
        mainDeck.Add(RedR2);
        PlusTwo redp21 = new PlusTwo("red", "+2");
        mainDeck.Add(redp21);
        PlusTwo redp22 = new PlusTwo("red", "+2");
        mainDeck.Add(redp22);

        Skip blueS1 = new Skip("blue", "S");
        mainDeck.Add(blueS1);
        Skip blueS2 = new Skip("blue", "S");
        mainDeck.Add(blueS2);
        Reverse blueR1 = new Reverse("blue", "R");
        mainDeck.Add(blueR1);
        Reverse blueR2 = new Reverse("blue", "R");
        mainDeck.Add(blueR2);
        PlusTwo bluep21 = new PlusTwo("blue", "+2");
        mainDeck.Add(bluep21);
        PlusTwo bluep22 = new PlusTwo("blue", "+2");
        mainDeck.Add(bluep22);

        Skip yelLowS1 = new Skip("yelLow", "S");
        mainDeck.Add(yelLowS1);
        Skip yelLowS2 = new Skip("yelLow", "S");
        mainDeck.Add(yelLowS2);
        Reverse RedR1 = new Reverse("yelLow", "R");
        mainDeck.Add(yelLowR1);
        Reverse yelLowR2 = new Reverse("yelLow", "R");
        mainDeck.Add(yelLowR2);
        PlusTwo yelLowp21 = new PlusTwo("yelLow", "+2");
        mainDeck.Add(yelLowp21);
        PlusTwo yelLowp22 = new PlusTwo("yelLow", "+2");
        mainDeck.Add(yellLwp22);

        Skip greenS1 = new Skip("green", "S");
        mainDeck.Add(greenS1);
        Skip greenS2 = new Skip("green", "S");
        mainDeck.Add(greenS2);
        Reverse greenR1 = new Reverse("green", "R");
        mainDeck.Add(greenR1);
        Reverse greenR2 = new Reverse("green", "R");
        mainDeck.Add(greenR2);
        PlusTwo greenp21 = new PlusTwo("green", "+2");
        mainDeck.Add(greenp21);
        PlusTwo greenp22 = new PlusTwo("green", "+2");
        mainDeck.Add(greenp22);

        wild wild1 = new wild("black", "w");
        mainDeck.Add(wildS1);
        wild wild2 = new wild("black", "w");
        mainDeck.Add(wildS2);
        wild wild3 = new wild("black", "w");
        mainDeck.Add(wild3);
        wild wild4 = new wild("black", "w");
        mainDeck.Add(wild4);
       
        PlusFour PlusFour1 = new PlusFour("black", "+4");
        mainDeck.Add(PlusFour1);
        PlusFour PlusFour2 = new PlusFour("black", "+4");
        mainDeck.Add(PlusFour2);
        PlusFour PlusFour3 = new PlusFour("black", "+4");
        mainDeck.Add(PlusFour3);
        PlusFour PlusFour4  = new PlusFour("black", "+4");
        mainDeck.Add(PlusFour4);
        
    }
}