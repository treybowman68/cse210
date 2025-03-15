
using System.Globalization;
using System.Xml.Schema;

public class Checklist : Goal{
   private readonly int _pointsPerStep;
   
    private readonly int _stepsToComplete;
    private int _stepsCompleted;

// this is a constructor below
    public Checklist(string goal,string description,int points,bool status,int pointsPerStep) : base(goal, description, points, status) {
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
    	public void Display(){
		//Goal
        //Description
        //Points
        //Status
        //PointsPerStep
        // Number of times done(Steps completed)
        // number of times until done(Steps to complete)
       Console.WriteLine($"Completed {_stepsCompleted}/ {_stepsToComplete} ");

	}



}