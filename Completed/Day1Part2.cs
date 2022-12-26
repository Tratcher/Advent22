using var reader = new StreamReader("Day1Input.txt");
var line = reader.ReadLine();
int current = 0;
var list = new SortedList<int, int>();
while (line != null)
{
    if (line == string.Empty)
    {
        Console.WriteLine(current);
        list.Add(current, current);
        current = 0;
    }
    else
    {
        current += int.Parse(line);
    }
    line = reader.ReadLine();
}
var highest3 = list.Values.Reverse().Take(3).Sum();
Console.WriteLine("Highest: " + highest3);