class DisplayJournal
{
    public string _filename;
    public List<string> _entries = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        "What did I learn about myself today?",
        "How can I be more Christ like in my daily life?",
        "How can I be more grateful for my family and friends?",
        "How can I show my love for God in my daily life?",
        "What can I do to be more kind to others?"
    };

    public void GetFileName()
    {
        Console.WriteLine("What is your journal's name?");
        _filename = Console.ReadLine();
    }
    public void LoadJournal()
    {
        foreach (string line in File.ReadLines(_filename))
        {
            _entries.Add(line);
        }
    }

    public void SaveJournal()
    {
        ;
    }
    public void ShowJournal()
    {
        ;
    }

}