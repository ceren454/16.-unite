using System;

class StringCompare
{
    static void Main()
    {
        string string1 = "hello";
        string string2 = "good bye";
        string string3 = "Happy Birthday";
        string string4 = "happy birthday";

        Console.WriteLine(
            $"string1 = \"{string1}\"\n" +
            $"string2 = \"{string2}\"\n" +
            $"string3 = \"{string3}\"\n" +
            $"string4 = \"{string4}\"\n"
        );

        Console.WriteLine(
            string1.Equals("hello")
                ? "string1 equals \"hello\""
                : "string1 does not equal \"hello\""
        );

        Console.WriteLine(
            string1 == "hello"
                ? "string1 equals \"hello\""
                : "string1 does not equal \"hello\""
        );

        Console.WriteLine(
            string.Equals(string3, string4)
                ? "string3 equals string4"
                : "string3 does not equal string4"
        );

        Console.WriteLine($"\nstring1.CompareTo(string2) is {string1.CompareTo(string2)}");
        Console.WriteLine($"string2.CompareTo(string1) is {string2.CompareTo(string1)}");
        Console.WriteLine($"string1.CompareTo(string1) is {string1.CompareTo(string1)}");
        Console.WriteLine($"string3.CompareTo(string4) is {string3.CompareTo(string4)}");
        Console.WriteLine($"string4.CompareTo(string3) is {string4.CompareTo(string3)}");
    }
}
