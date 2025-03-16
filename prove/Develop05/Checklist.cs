
public class Checklist : Goal{
   private readonly int _pointsPerStep;
   
    private readonly int _stepsToComplete;
    private int _stepsCompleted = 0;

// this is a constructor below
    public Checklist(string goal, string description, int points, int stepsToComplete, int pointsPerStep) : base(goal, description, points) {
        _stepsToComplete = stepsToComplete;
        _pointsPerStep = pointsPerStep;
    }
    public override int MarkComplete()
    {
        if (_status) return 0;
        // incremented 
        _stepsCompleted += 1;
        if (_stepsToComplete != _stepsCompleted) return _pointsPerStep;
        _status = true;
		return _points;
    }
    
    //for checklist goals it should show how many times the goal 
    // has been completed (for example Completed 2/5 times).
    public override void Display() {
		Console.WriteLine($"{GetCheckbox()} {_goal} - {_points} - {_stepsCompleted}/{_stepsToComplete}\n > {_description} ");
	}

    public override string ToString()
    {
        return $"{GetCheckbox()} {_goal} {_stepsCompleted}/{_stepsToComplete}";
    }

}