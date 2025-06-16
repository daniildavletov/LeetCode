namespace Problems;

public class FindPeakElementSolution
{
    public int FindPeakElement(int[] nums)
    {
        int midIndex = nums.Length / 2;
        
        int peak = 0;

        while (peak == 0)
        {
            if (midIndex == 0)
            {
                peak = nums[midIndex];
                continue;
            }
            
            if (midIndex == nums.Length - 1)
            {
                if (nums[midIndex] > nums[midIndex-1])
                {
                    peak = nums[midIndex];   
                }
                else
                {
                    return midIndex - 1;
                }
                continue;
            }
            
            if (nums[midIndex] > nums[midIndex-1])
            {
                if (nums[midIndex] < nums[midIndex+1])
                {
                    midIndex++;
                    continue;
                }

                peak = nums[midIndex];
                continue;
            }
            midIndex--;
        }
        
        return midIndex;
    }
}