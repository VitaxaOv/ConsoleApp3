namespace ConsoleApp3;

public static class UsefulMethods
{
    public static int[] ReadArray()
    {
        return new [] { 1 };
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i <= array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine("");
    }

    public static int[] ToArray(int number)
    {
        return new int[]{1};
    }

    public static int[] GetReverseArray(int[] array)
    {
        int[] result = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[array.Length - 1 - i ];
        }

        return result;
    }

    public static double Calculate(int a, int b, int c, int k)
    {
        int sum = a + b;
        return a + b;
    }

    public static bool CompareArrays(int[] left, int[] right)
    {
        if (left.Length != right.Length)
        {
            return false;
        }
        
        for(int i = 0; i < left.Length; i++)
        {
            if (left[i] != right[i])
            {
                return false;
            }
        }

        return true;
    }
}