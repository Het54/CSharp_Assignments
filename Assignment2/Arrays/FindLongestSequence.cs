namespace Assignment2;

public static class FindLongestSequence
{
    public static void LongestSequence(int[] arr)
    {
        int maxLength = 1;
        int maxElement = arr[0];
        int currentLength = 1;
        int currentElement = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == currentElement)
            {
                currentLength++;
            }
            else
            {
                currentElement = arr[i];
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxElement = currentElement;
            }
        }

        Console.WriteLine("Longest sequence of equal elements:");
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(maxElement + " ");
        }
        Console.WriteLine();
    }
}