using System;

class Program
{
    static void Main(string[] args)
    {
        // Construct Scripture Class
        var scripture1 = new Scripture(
            "7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
            "1 Nephi", 3, 7
        );
        var scripture2 = new Scripture(
            [
                "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
                "6 In all thy ways acknowledge him, and he shall direct thy paths"
            ],
            "Proverbs", 3, 5, 6
        );
        var scripture = new Random().Next(2) == 1 ? scripture1 : scripture2;

        Console.Clear();
        while(!scripture.IsCompletelyhidden()){
            scripture.Display();
            Console.Write("\n\npress enter to hide a word or quit to stop");
            string input = Console.ReadLine();
            Console.Clear();
            if (input.ToLower() == "quit") Environment.Exit(0);
            scripture.HideWord();
        }

    }
}