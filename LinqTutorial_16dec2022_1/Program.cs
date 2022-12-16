namespace LinqTutorial_16dec2022_1;

internal class Program
{
    static void Main(string[] args)
    {
        var words = new List<string> { "a", "bb", "ccc", "dddd" };
        var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

        Console.WriteLine(string.Join(", ", wordsLongerThan2Letters));
    }
}