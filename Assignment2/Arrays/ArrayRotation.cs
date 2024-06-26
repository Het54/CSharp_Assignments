namespace Assignment2;

public static class ArrayRotation
{
    public static int[] RotationOfArrays(int[] numbers, int[] sum, int rotations)
    {
        
        int count = 1;

        while (count <= rotations)
        {
            int[] newList = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int l = i;
                int realposition = (l + count) % numbers.Length;
                newList[realposition] = numbers[i];
            }
    
            for (int i = 0; i < numbers.Length; i++)
            {
                sum[i] += newList[i];
            }

            if (count == rotations)
            {
                Console.WriteLine($"Rotated Array{count}: ");
                foreach (int i in newList)
                {
                    Console.Write($"{i} ");
                }

                
            }

            count++;

        }

        return sum;


    }
}