namespace Assignment2;

public static class FindMostFrequent
{
    public static void LongestSequence(int[] arr)
    {

        Dictionary<int, int> freqDict = new Dictionary<int, int>();
        int maxFrequency = 0;
        int maostFrequentNumber = arr[0];

        foreach (int element in arr)
        {
            if (freqDict.ContainsKey(element))
            {
                freqDict[element]++;
            }
            else
            {
                freqDict[element] = 1;
            }

            if (freqDict[element] > maxFrequency)
            {
                maxFrequency = freqDict[element];
                maostFrequentNumber = element;
            }
        }
    
        foreach (int number in arr)
        {
            if (freqDict[number] == maxFrequency)
            {
                maostFrequentNumber = number;
                break;
            }
        }

        Console.WriteLine($"The number {maostFrequentNumber} is the most frequent (occurs {maxFrequency} times)");
    
    

    }
}