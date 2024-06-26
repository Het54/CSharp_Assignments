// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Hackername Generator");

Console.WriteLine("What is your favorite color: ");
String favcolor = Console.ReadLine();

Console.WriteLine("What is your astrology sign: ");
String astrologysign = Console.ReadLine();

Console.WriteLine("What is your street address number: ");
int streetnumber = int.Parse(Console.ReadLine());

String Hackername = favcolor + astrologysign + streetnumber.ToString();

Console.WriteLine($"Your Hackername is: {Hackername}");

string[] datatypes = {"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};






