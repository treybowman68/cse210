
public class Scripture{
    private Reference _reference;
    private readonly List<Word> _words = [];

    public Scripture(string verseText, string book, int chapter, int verseStart, int? verseEnd = null) {
        string[] words = verseText.Split(" ");
        foreach(string word in words){
            _words.Add(new Word(word));
        }
        _reference = new Reference(book, chapter, verseStart, verseEnd);
    }
    public Scripture(string[] verseText, string book, int chapter, int verseStart, int? verseEnd = null) {
        // Multiple Verses
        string[] words = string.Join(" \n", verseText).Split(" ");
        foreach(string word in words){
            _words.Add(new Word(word));
        }

        _reference = new Reference(book, chapter, verseStart, verseEnd);
    }

    public void Display() {
        Console.WriteLine(_reference);
        _words.ForEach(w => Console.Write(w + " "));
    }

    public void HideWord() {
        if (IsCompletelyhidden()) return;
        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());
        Random r = new();
        visibleWords[r.Next(visibleWords.Count)].Hide();
    }

    public bool IsCompletelyhidden() {
        return _words.All(w => w.IsHidden());
    }
}