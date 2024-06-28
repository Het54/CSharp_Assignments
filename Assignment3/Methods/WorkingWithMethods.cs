// See https://aka.ms/new-console-template for more information


Console.WriteLine("Working with methods");
Console.WriteLine("Q1");

int[] GenerateNumbers(int len)
{
    int[] result = new int[len];
    Random random = new Random();

    for (int i = 0; i < len; i++)
    {
        int randomNumber = random.Next(1,9);
        result[i] = randomNumber;
    }

    return result;
}


void Reverse(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length - i - 1; j++)
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }

    foreach (int val in numbers)
    {
        Console.Write(val);
    }
    
}

void PrintNumbers(int[] numbers)
{
    foreach (int var in numbers)
    {
        Console.Write(var);
        
    }
    Console.WriteLine();
}

Console.WriteLine("Enter the size of the Array: ");
int length = int.Parse(Console.ReadLine());
int[] arr = GenerateNumbers(length);
PrintNumbers(arr);
Reverse(arr);
Console.WriteLine();

Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Q2");




int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n; 
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive call
    }
}


Console.WriteLine("Enter the index for fibonacci sequence: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"Fibonacci sequence at {n}th index: ");


Console.Write(Fibonacci(8));

Console.WriteLine();






