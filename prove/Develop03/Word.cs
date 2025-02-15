public class Word {
    private string _word;
    private bool _ishidden = false;
    
    public Word(string text) {
        _word = text;
    }

    public bool IsHidden() {
        return _ishidden;
    }
    
    public void Hide() {
        _ishidden = true;
    }

    public override string ToString() {
        return _ishidden ? new string('_', _word.Length) : _word;
    }

}