using System.Linq;

public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        var binaryStr = encodedCount.ToString("B");
        return binaryStr.Count(c => c == '1');
    }
}
