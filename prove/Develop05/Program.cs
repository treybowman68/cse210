using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();

        string[] options = [
            "Add Goal",
            "Delete Goal",
            "List Goals",
            "Complete Goal",
            "Exit"
        ];
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine($"Current Points: {manager.GetPoints()}");
            choice = MenuUtils.GetMenuChoice("Main Menu:", options, "Select an option: ");
            switch (choice) {
                case 1:
                    manager.AddGoal();
                    break;
                case 2:
                    manager.DeleteGoal();
                    break;
                case 3:
                    manager.DisplayAllGoals();
                    break;
                case 4:
                    manager.CompleteGoal();
                    break;
                case 5:
                    Console.WriteLine("Thanks for using the program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
                  
}