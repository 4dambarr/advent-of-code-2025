namespace advent_of_code_2025.DailySolutions;

public static class DayOne
{
    public static void PartOne()
    {
        var inputStrings = File.ReadAllLines("Assets/DayOnePassword.txt");
        var zeroCount = 0;
        var pos = 50;
        foreach (var line in inputStrings)
        {
            var direction = line[0] == 'L' ? 1 : -1;
            var rotation = int.Parse(line.Substring(1));
            pos += (direction * rotation);
            pos %= 100;
            if (pos == 0) zeroCount++;
        }
        Console.WriteLine(zeroCount);
        // Answer: 1152
    }

    public static void PartTwo()
    {
        var inputStrings = File.ReadAllLines("Assets/DayOnePassword.txt");
        var zeroCount = 0;
        var pos = 50;
        foreach (var line in inputStrings)
        {
            var direction = line[0] == 'L' ? 1 : -1;
            var rotation = int.Parse(line.Substring(1));
            if (rotation >= 100)
            {
                zeroCount += (int)(rotation / 100);
            }
            var newPos = pos + (direction * (rotation % 100));
            
            if (newPos >= 100 || newPos <= -100 || (newPos > 0 && pos < 0) || (newPos < 0 && pos > 0) || newPos == 0) zeroCount++;
            pos = newPos % 100;
        }
        
        Console.WriteLine(zeroCount);
        // Answer: 6671
    }
}