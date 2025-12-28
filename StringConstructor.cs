using System;

class StringConstructor
{
    static void Main()
    {
        char[] chars = { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };

        string original = "Welcome to C# programming!";
        string string1 = original;
        string string2 = new string(chars);
        string string3 = new string(chars, 6, 3);
        string string4 = new string('C', 5);

        Console.WriteLine(
            $"string1 = \"{string1}\"\n" +
            $"string2 = \"{string2}\"\n" +
            $"string3 = \"{string3}\"\n" +
            $"string4 = \"{string4}\"\n"
        );
    }
}
