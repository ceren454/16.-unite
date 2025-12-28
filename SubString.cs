using System;

class SubString
{
    static void Main()
    {
        string letters = "abcdefghijklmabcdefghijklm";

        string part1 = letters.Substring(20);
        string part2 = letters.Substring(0, 6);

        Console.WriteLine($"Substring from index 20 to end is \"{part1}\"");
        Console.WriteLine($"Substring from index 0 of length 6 is \"{part2}\"");
    }
}
