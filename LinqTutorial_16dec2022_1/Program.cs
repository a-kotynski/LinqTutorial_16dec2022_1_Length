namespace LinqTutorial_16dec2022_1;

public static class StringExtensions
{
    public static int GetCountOfLines(this string input)
    {
        return input.Split("\n").Length;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        var words = new List<string> { "a", "bb", "ccc", "dddd" };
        var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

        Console.WriteLine(string.Join(", ", wordsLongerThan2Letters));

        var multilineString = @"
""Please give me a ride on your back!”
Said the Duck to the Kangaroo.
“I woulds it quite still, and say nothing but‘ Quack’,
The whole of the long day through!
And we’d got otheDee,and the Jelly BoLee,
Over the land ,and over the sea;
Please take me avride!Odo!”
Said the Duck to the Kangaroo.";

        var countOfLines = multilineString.GetCountOfLines();
        Console.WriteLine(countOfLines);
    }
}