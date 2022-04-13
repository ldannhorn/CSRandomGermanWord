// See https://aka.ms/new-console-template for more information
using System;
string[] wordlist = System.IO.File.ReadAllLines(@"de.txt");




string generateRandomString(int length)
{
    var chars = "abcdefghijklmnopqrstuvwxyz";
    var stringChars = new char[length];
    var random = new Random();

    for (int i = 0; i < stringChars.Length; i++)
    {
        stringChars[i] = chars[random.Next(chars.Length)];
    }
    return new String(stringChars);
}

bool wordFound(int length, string word)
{
    System.Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan; System.Console.WriteLine("Länge des Wortes: {0}", length); Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Green; System.Console.WriteLine(word); Console.ForegroundColor = ConsoleColor.White;
    System.Console.ReadLine();
    findWord();
    return true;
}


bool findWord()
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Cyan; System.Console.Write("Länge des Wortes: "); Console.ForegroundColor = ConsoleColor.White;
        int length = int.Parse(Console.ReadLine());
        while (true)
        {
            string rString = generateRandomString(length);
            Console.ForegroundColor = ConsoleColor.Green; System.Console.WriteLine(rString); Console.ForegroundColor = ConsoleColor.White;

            var check = Array.Exists(wordlist, x => x == rString);
            if (check == true)
            {
                wordFound(length, rString);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan; System.Console.WriteLine("Länge des Wortes: {0}", length); Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}





findWord();
System.Console.ReadLine();