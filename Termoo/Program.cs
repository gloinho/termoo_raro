using Game;

System.Console.WriteLine("Welcome to Termoo Raro Console Program!!!");
Termoo game = new Termoo();
do
{
    System.Console.WriteLine();
    System.Console.Write($"Write your #{game.Count + 1} word (5 letters): ");
    string word = Console.ReadLine();
    List<string> responses = game.Play(word);
    System.Console.WriteLine();
    foreach (string response in responses)
    {
        System.Console.WriteLine(response);
    }
} while (game.Count <= 4);
