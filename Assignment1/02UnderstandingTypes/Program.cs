// See https://aka.ms/new-console-template for more information

Console.WriteLine();
Console.WriteLine("Practice number sizes and ranges");
Console.WriteLine("Q1. Size of different data types");

string[] datatypes = {"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};

int[] bytes = { 1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 16 };

String[] minvalues = {"-128", "0", "-32,768", "0", "-2,147,483,648", "0", "-9,223,372,036,854,775,808", "0", "+-1.0e-45", "+-5e-324", "+-1.0x10e-28"};

string[] maxvalues = {"127", "255", "32,767", "65,535", "2,147,483,647", "4,294,967,295", "9,223,372,036,854,775,807", "18,446,744,073,709,551,615", "+-3.4e38", "+-1.7e308", "+-7.9e28"};

Console.WriteLine("{0,-20} {1,-20} {2,-50} {3,-50}\n", "datatypes", "bytes", "Minimum value", "Maximum value");

for (int i = 0; i < datatypes.Length; i++)
{
    Console.WriteLine("{0,-20} {1,-20:N0} {2,-50} {3,-50}", datatypes[i], bytes[i], minvalues[i], maxvalues[i]);
}


Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Q2. Conerting centuries to years, days, hours, and so on...");

Console.WriteLine("Input: ");
int input = int.Parse(Console.ReadLine());

int centuries = input;
int years = centuries * 100;
long days = years * 365 + years / 4 - years / 100 + years / 400; 
long hours;
try
{
    checked
    {
        hours = days * 24;
    }
}
catch (Exception e)
{
    hours = days;
}




long minutes;
try
{
    checked
    {
        minutes = hours * 60;
    }
}
catch (Exception e)
{
    minutes = hours;
}

long seconds;
try
{
    checked
    {
        seconds = minutes * 60; 
    }
}
catch (Exception e)
{
    seconds = minutes;
}


long milliseconds;
try
{
    checked
    {
        milliseconds = seconds * 1000;
    }
}
catch (Exception e)
{
    milliseconds = seconds;
}

long microseconds;
try
{
    checked
    {
        microseconds = milliseconds * 1000;
    }
}
catch (OverflowException e)
{
    microseconds = milliseconds;
}



long nanoseconds;
try
{
    checked
    {
        nanoseconds = microseconds * 1000;
    }
}
catch (OverflowException e)
{
    nanoseconds = microseconds;
}




Console.WriteLine($"Output: {centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");





 