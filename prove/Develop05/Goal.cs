

public class Goal{
    protected string _goal;
    protected string _description;
    protected int _points;
    protected bool _status = false;
	public Goal(string goal,string description,int points) {
		_goal = goal;
		_description = description;
		_points = points;
	}

	public virtual void Display(){
		Console.WriteLine($"{GetCheckbox()} {_goal} - {_points}\n > {_description} ");
	}

	protected string GetCheckbox() {
		return _status ? "[x]" : "[ ]" ;
	}

	public virtual int MarkComplete() {
		if (_status) return 0;
		_status = true;
		return _points;
	}

	public override string ToString()
    {
        return $"{GetCheckbox()} {_goal}";
    }


	
}