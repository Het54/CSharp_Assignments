// See https://aka.ms/new-console-template for more information

using Assignment_4;



Console.WriteLine("Practice working with Generics");
Console.WriteLine("Q1.");
Console.WriteLine();

MyStack<string> myStack = new MyStack<string>();

myStack.Push("Apple");
Console.WriteLine($"Stack count: {myStack.Count()}");
myStack.Push("Banana");
Console.WriteLine($"Stack count: {myStack.Count()}");
myStack.Push("Cherry");
Console.WriteLine($"Stack count: {myStack.Count()}");
try
{
    Console.WriteLine($"Item Removed: {myStack.Pop()}");
    Console.WriteLine($"Item Removed: {myStack.Pop()}");
    Console.WriteLine($"Item Removed: {myStack.Pop()}");
    Console.WriteLine($"Item Removed: {myStack.Pop()}");
}
catch(InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"Stack count: {myStack.Count()}");


Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Q2.");
Console.WriteLine();


MyList<int> myList = new MyList<int>();

myList.Add(1);
myList.Add(2);
myList.Add(3);

Console.WriteLine("List contains 2: " + myList.Contains(2));

try
{
    Console.WriteLine("Removing element at index 1: " + myList.Remove(1));
    Console.WriteLine("Removing element at index 1: " + myList.Remove(4));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Element at index 1: " + myList.Find(1));
myList.InsertAt(4, 1);
Console.WriteLine("Element at index 1: " + myList.Find(1));

try
{
    myList.DeleteAt(0);
    Console.WriteLine("Element at index 0 after deletion: " + myList.Find(0));
    myList.DeleteAt(4);
    Console.WriteLine("Element at index 0 after deletion: " + myList.Find(0));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

myList.Clear();
try
{
    Console.WriteLine("List cleared. Count: " + myList.Find(0));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}









