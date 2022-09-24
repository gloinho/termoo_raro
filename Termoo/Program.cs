using Game;

System.Console.WriteLine("Welcome to Termoo Raro Console Program!!!");
Termoo game = new Termoo();
for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine();
    System.Console.Write($"Write your #{i} word (5 letters): ");
    string word = Console.ReadLine();
    System.Console.WriteLine();
    List<string> responses = game.Play(word);
    foreach (string response in responses)
    {
        System.Console.WriteLine(response);
    }
    if (responses.Contains("Invalid Word"))
    {
        i--;
    }
    if (responses.Contains("You won!"))
    {
        break;
    }
}
