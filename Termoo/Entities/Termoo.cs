namespace Game;

public class Termoo
{
    public int Count { get; private set; }
    public string Word { get; set; }

    public Termoo()
    {
        Count = 0;
        string[] file = File.ReadLines(
                "C:\\Users\\gloin\\Desktop\\C#_Studies\\Raro\\TermooRaro\\Termoo\\Assets\\valid-wordle-words.txt"
            )
            .ToArray();
        int lineCount = file.Count();
        Random line = new Random();
        Word = file[line.Next(0, lineCount - 1)];
    }

    public List<string> Play(string word)
    {
        List<string> responses = Response.WordCheck(Word, word.ToLower(), Count);
        if (!responses.Contains("Invalid word"))
        {
            Count++;
        }
        return responses;
    }
}
