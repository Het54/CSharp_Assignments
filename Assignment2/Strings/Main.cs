// See https://aka.ms/new-console-template for more information

using Strings;

Console.WriteLine();

Console.WriteLine();

Console.WriteLine("Q1. Reverse a string");
Console.WriteLine();

Console.WriteLine("Enter a String: ");
string str = Console.ReadLine();

ReverseAstring.Reverse(str);


Console.WriteLine();

Console.WriteLine();


Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q2. Reverse a Sentenece");
Console.WriteLine();


Console.WriteLine("Enter a String: ");
string sentence = Console.ReadLine();

string rsentence = ReverseWordsInSen.ReverseWordsInSentence(sentence);

Console.WriteLine(rsentence);

Console.WriteLine();

Console.WriteLine();


Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q3. Find Palindrome");
Console.WriteLine();


Console.WriteLine("Enter a String: ");
string psentence = Console.ReadLine();

List<string> palindrom = Palindrom.GetPalindromes(psentence);

foreach (string pal in palindrom)
{
    Console.Write($"{pal}, ");
}


Console.WriteLine();

Console.WriteLine();


Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q4. Disect URL");
Console.WriteLine();


Console.WriteLine("Enter a String: ");
string url = Console.ReadLine();

UrlDisection.UrlDis(url);




