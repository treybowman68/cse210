public class Eternal : Goal
{
    public Eternal(string goal, string description, int points) : base(goal, description, points) {}

    public override int MarkComplete()
    {
        return _points;
    }

}