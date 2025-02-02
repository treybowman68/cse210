using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public string Menu()
    {
        return "\n1. Add Entry\n2. Save to File\n3. Load from File\n4. Quit\nChoose an option: ";
    }

    public string AddEntry(DateTime date)
    {
        Entry newEntry = new Entry(date);
        _entries.Add(newEntry);
        return $"Entry added: {newEntry.date}";
    }

    public void SaveToFile(string filePath)
    {
        Console.WriteLine("What would you like the file to be named?");
        string fileName = Console.ReadLine();
        
        List<string> lines = new List<string>();
        foreach (Entry x in _entries)
        {
            lines.Add(x.displayEntry());
        }
        
        File.WriteAllLines(fileName, lines);
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            _entries.Clear(); // Clear existing entries

            foreach (string line in lines)
            {
                Entry newEntry = new Entry(line); // Modify this based on your Entry constructor
                _entries.Add(newEntry);
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void Quit()
    {
        Console.WriteLine("Exiting Journal Application...");
    }
}
