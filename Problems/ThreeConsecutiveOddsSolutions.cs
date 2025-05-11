namespace Problems;

public class ThreeConsecutiveOddsSolutions
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        int счетчикНечетныхЧисел = 0;

        foreach (var odd in arr)
        {
            if (odd % 2 == 0)
            {
                счетчикНечетныхЧисел = 0;
                continue;
            }

            счетчикНечетныхЧисел++;

            if (счетчикНечетныхЧисел == 3)
            {
                return true;
            }
        }

        return false;
    }
}