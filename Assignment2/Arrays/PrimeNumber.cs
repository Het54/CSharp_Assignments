namespace Assignment2;

public static class PrimeNumber
{
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        if (startNum < 2) startNum = 2;
        int[] primeList = new int[endNum-startNum];
        int index = 0;
        for (int i = startNum; i <= endNum ; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
            
                if (i % j == 0)
                {
                    isPrime = false;
                }
            
            
            }

            if (isPrime == true)
            {
                primeList[index] = i;
                index++;
            }
        } 

        Array.Resize(ref primeList, index);
        return primeList;
    }
    
}