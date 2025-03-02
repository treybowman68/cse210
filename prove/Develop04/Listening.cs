using System;
public class Listening : Activity {
      public Listening() : base()
    {
        _name = "Listening";
        _description = "This activity will help you reflect on the good things in your life";
    
    }
    protected List<string> main_prompt = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    protected List<string> prompt_answers = new List<string>{};

    public override void StartActivity(){
        Console.WriteLine(_description);
        Random random = new Random();
        Console.WriteLine(main_prompt[random.Next(0, 4)]);
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("Go!");
        Console.WriteLine();

        DateTime end_time = DateTime.Now;
        end_time = end_time.AddSeconds(_duration);
        DateTime now = DateTime.Now;
        while(now < end_time){
            string answer = Console.ReadLine();
            prompt_answers.Add(answer);

            now = DateTime.Now;
        }
        Console.WriteLine("Time's Up!");
        Thread.Sleep(1000);
        Console.WriteLine("Your answers were:");
        foreach (string ans in prompt_answers){
            Console.WriteLine(ans);
        }
        Console.WriteLine(_endMessage);
        Console.WriteLine("You did the listening activity for "+_duration+" seconds");
    }
}