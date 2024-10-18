public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        var high = input.Length - 1;
        var low = 0;
        int middle;

        while (low <= high)
        {
            middle = (high + low) / 2;
            
            if (input[middle] == value) return middle;
            if (input[middle] > value) high = middle - 1;
            if (input[middle] < value) low = middle + 1;
        }

        return -1;
    }
}