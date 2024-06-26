// See https://aka.ms/new-console-template for more information

using Assignment2;


Console.WriteLine("Question 1) Copying an Array: ");
Console.WriteLine();

int[] initialArray = new int[10];

for (int it = 0; it < 10; it++)
{
    initialArray[it] = it + 2;
}
Console.WriteLine("Initial Array:");
foreach (int initial in initialArray)
{
    
    Console.Write(initial);
}
Console.WriteLine();

int[] secondArray = new int[initialArray.Length];

for (int it = 0; it < initialArray.Length; it++)
{
    Console.WriteLine($"Initial Array Value: {initialArray[it]}");
    secondArray[it] = initialArray[it];
    Console.WriteLine($"Second Array Value after copying: {secondArray[it]}");
}

Console.WriteLine("Initial Array:");
foreach (int secondary in secondArray)
{
    
    Console.Write(secondary);
}
Console.WriteLine();

Console.WriteLine();


Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q2. List Management system");

ItemList i = new ItemList();
i.itemList = [];
i.Tally();


Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q3. Finding Prime numbers in a range");

Console.WriteLine();
Console.WriteLine("Enter the start of the range");
int start = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter the end of the range: ");
int end = int.Parse(Console.ReadLine());
int[] primeList = PrimeNumber.FindPrimesInRange(start, end);
Console.WriteLine("List of prime numbers: ");
Console.WriteLine();
foreach (int p in primeList)
{
    Console.WriteLine(p);
}


Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q4. Rotation of Array and finding the sum");

Console.WriteLine("Enter elements separated by spaces:");
string input = Console.ReadLine();
string[] elements = input.Split(' ');
int[] numbers = Array.ConvertAll(elements, int.Parse);
int rotation = int.Parse(Console.ReadLine());


int[] sum = new int[numbers.Length];
for (int s = 0; s < numbers.Length; s++)
{
    sum[s] = 0;
}

int[] finalsum = ArrayRotation.RotationOfArrays(numbers, sum, rotation); 
Console.WriteLine();
Console.WriteLine("Sum: ");
foreach (int fs in finalsum)
{
    
    Console.Write($"{fs} ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q5. Finding the longest sequence");

Console.WriteLine("Enter elements separated by spaces:");
string findSequenceArray = Console.ReadLine();
string[] el = findSequenceArray.Split(' ');
int[] findSeqArray = Array.ConvertAll(el, int.Parse);
FindLongestSequence.LongestSequence(findSeqArray);


Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

Console.WriteLine("Q7. Finding the longest sequence");

Console.WriteLine("Enter elements separated by spaces:");
string findFrequentNumber = Console.ReadLine();
string[] ell = findFrequentNumber.Split(' ');
int[] findFreqNum = Array.ConvertAll(ell, int.Parse);
FindMostFrequent.LongestSequence(findFreqNum);








































