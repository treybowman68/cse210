
using System.Net;

public class Goal{
    protected string _goal;
    protected string _description;
    protected int _points;
    protected bool _status;
	public Goal(string goal,string description,int points,bool status) {
		_goal = goal;
		_description = description;
		_points = points;
		_status = status;
	}

	public void Display(){
		string checkbox = _status ? "[x]" : "[ ]" ;
		Console.WriteLine($"{checkbox} {_goal} - {_points}\n > {_description} ");
	}

	public virtual int MarkComplete() {
		if (_status) return 0;
		_status = true;
		return _points;
	}

	
}