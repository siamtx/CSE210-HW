using System.Security.Cryptography.X509Certificates;

class Journal
{
    public string _filename;

    // create list of prompts.
    public List<string> _entries = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn about myself today?",
        "How can I be more Christ like in my daily life?",
        "How can I be more grateful for my family and friends?",
        "How can I show my love for God in my daily life?",
        "What can I do to be more kind to others?"
    };

    public List<string> _response = new List<string>
    {

    };

    // prompt user for response  
    public void Entry()
    {
        Random rng = new Random();
        string prompt = _entries[rng.Next(_entries.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();

        // Save response to response list.
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        _response.Add(date);
        _response.Add(prompt);
        _response.Add(response);

        Console.WriteLine("\nEntry saved!\n");

    }

    // prompt user for filename to load saved journal.
    public void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        _filename = Console.ReadLine();

        if (!File.Exists(_filename))
        {
            Console.WriteLine($"File {_filename} not found.");
            return;
        }

        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                _entries.Add(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }

    }
    // prompt user for filename to save journal.
    public void SaveJournal()
    {
        Console.Write("Enter filename to save to (e.g. journal.txt): ");
        _filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(_filename))
            {
                foreach (string entry in _entries)
                {
                    writer.WriteLine(entry);
                }
            }

            File.WriteAllLines(_filename, _entries);
            Console.WriteLine($"Journal saved to {_filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }


    public void ShowJournal()
    {
        if (_response.Count == 0)
        {
            Console.WriteLine("\nNo entries yet.\n");
            return;
        }

        foreach (string entry in _response)
        {
            string date = _response[0];
            string prompt = _response[1];
            string response = _response[2];
            Console.WriteLine($"Date: {date} - Prompt: {prompt} ");
            Console.WriteLine($"Response:{response}");
        }
        Console.WriteLine();

    }

}