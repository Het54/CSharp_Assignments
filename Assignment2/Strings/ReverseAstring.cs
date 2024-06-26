namespace Strings;

public static class ReverseAstring
{
    public static void Reverse(string str)
    {
        
        Console.WriteLine("Convert the string to char array, reverse it, then convert it to string again");
        char[] arr = str.ToCharArray();

        Array.Reverse(arr);
        string str1 = new string(arr);
        Console.WriteLine(str1);
        
        Console.WriteLine();
        Console.WriteLine("Print the letters of the string in back direction (from the last to the first) in a for-loop");
        for (int i = str.Length-1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }

        
    }
}