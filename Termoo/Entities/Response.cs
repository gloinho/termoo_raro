namespace Game;

public class Response
{
    public static List<string> WordCheck(string word, string wordToCheck, int count)
    {
        List<string> Responses = new List<string>();
        if (!IsValidWord(wordToCheck))
        {
            Responses.Add("Invalid Word");
        }
        else
        {
            if (word == wordToCheck)
            {
                Responses.Add("You won!");
            }
            else if (count == 4)
            {
                Responses.Add($"You lost!");
                Responses.Add($"The word was {word}");
            }
            else
            {
                for (int position = 0; position < word.Length; position++)
                {
                    if (word.Contains(wordToCheck[position]))
                    {
                        if (
                            wordToCheck.IndexOf(word[position], position)
                            == word.IndexOf(word[position], position)
                        )
                            Responses.Add(
                                $"Letter {wordToCheck[position]} is in the right position"
                            );
                        else
                        {
                            Responses.Add(
                                $"Letter {wordToCheck[position]} is not in the right position"
                            );
                        }
                    }
                    else
                    {
                        Responses.Add($"Word does not contains letter {wordToCheck[position]}");
                    }
                }
            }
        }

        return Responses;
    }

    private static bool IsValidWord(string word)
    {
        string[] file = File.ReadLines(
                "C:\\Users\\gloin\\Desktop\\C#_Studies\\Raro\\TermooRaro\\Termoo\\Assets\\valid-wordle-words.txt"
            )
            .ToArray();
        if (!file.Contains(word))
        {
            return false;
        }
        foreach (char letter in word)
        {
            if (!Char.IsLetter(letter) || word.Length != 5)
            {
                return false;
            }
        }
        return true;
    }
}
