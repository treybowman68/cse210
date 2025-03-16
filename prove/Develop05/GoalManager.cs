public class GoalManager {

    private readonly List<Goal> _goals = [];
    private int _points = 0;

    public GoalManager() {}


    // Class Methods
    public void AddGoal() {
        string[] goalTypes = ["Simple", "Eternal", "Checklist"];
        int choice = MenuUtils.GetMenuChoice("Types of goals", goalTypes, "Which goal would you like to create? ");
        Type type = Type.GetType(goalTypes[choice - 1]);
        
        List<object> args = [];

        Console.Write("Give a goal name: ");
        args.Add(Console.ReadLine());
        Console.Write("Give a goal description: ");
        args.Add(Console.ReadLine());
        args.Add(MenuUtils.GetValidInt("How many points on completion? ", 0, 5000));

        if (choice == 3) {
            args.Add(MenuUtils.GetValidInt("How many steps to complete the goal? ", 0, 10));
            args.Add(MenuUtils.GetValidInt("How many points for completing a step? ", 0, 250));
        }

        _goals.Add(ConstructGoal(type, args.ToArray()));
        Console.WriteLine("Goal Added.");
    }

    private static Goal ConstructGoal(Type goalType, object[] args) {
        return (Goal)Activator.CreateInstance(goalType, args);
    }

    public void Save() {

    }

    public void Load() {

    }

    private Goal ChooseGoal(string prompt) {
        int choice = MenuUtils.GetMenuChoice("Select a goal: ", _goals.Select(g => g.ToString()).ToArray(), prompt);
        return _goals[choice - 1];
    }

    public void DeleteGoal() {
        if (_goals.Count == 0) {
            Console.WriteLine("There are no goals yet!");
            return;
        }
        Goal goal = ChooseGoal("Which Goal would you like to delete? ");
        _goals.Remove(goal);
    }

    public void CompleteGoal() {
        if (_goals.Count == 0) {
            Console.WriteLine("There are no goals yet!");
            return;
        }
        _points += ChooseGoal("Which Goal would you like to mark complete? ").MarkComplete();
    }

    public void DisplayAllGoals() {
        if (_goals.Count == 0) {
            Console.WriteLine("There are no goals yet!");
            return;
        }
        _goals.ForEach(g => g.Display());
    }

    public int GetPoints() {
        return _points;
    }

}