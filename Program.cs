
using var reader = new StreamReader("Day1Input.txt");
var line = reader.ReadLine();
int highest = 0, current = 0;
while (line != null)
{
    if (line == string.Empty)
    {
        Console.WriteLine(current);
        if (current > highest) highest = current;
        current = 0;
    }
    else
    {
        current += int.Parse(line);
    }
    line = reader.ReadLine();
}
Console.WriteLine("Highest: " + highest);

