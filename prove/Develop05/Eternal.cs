public class Eternal : Goal
{
    public Eternal(string goal, string description, int points, bool status) : base(goal, description, points, status) {}

    public override int MarkComplete()
    {
        return _points;
    }

}