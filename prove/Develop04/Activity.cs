public abstract class Activity {
    protected string _activityName;
    protected  string _description;
    protected string _endMessage;
    protected int _duration;
    protected string _name;
    
    public Activity() {
        Console.WriteLine("How long would you like to perform the activity for? (In seconds)");
        string userInput = Console.ReadLine();
        _duration =int.Parse(userInput);
    }
    public void Run() {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.Write("How long would you like to do this activity for? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_description);
        StartActivity();
        Console.WriteLine(_endMessage);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity");
        Console.WriteLine("Well Done!!");

    }

    public abstract void StartActivity();

    public int GetDuration(){
        return _duration;
    }

    // Helper methods 
    protected static void DoForDuration(Action voidFunction, int duration) {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime) voidFunction();
    }
}