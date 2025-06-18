namespace Problems;

public class DivideArrayIntoArraysWithMaxDifference
{
    // TODO: можно упростить, ходить по цику через +3
    public int[][] DivideArray(int[] nums, int k)
    {
        if (nums.Length % 3 != 0)
        {
            return [];
        }

        Array.Sort(nums);
        
        int[][] resultArray = new int[nums.Length / 3][];
        
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 3 == 0 && nums[i+2] - nums[i] > k)
            {
                resultArray = [];
                break;
            }

            if (resultArray[j] == null)
            {
                resultArray[j] = new int[3];
            }
            
            resultArray[j][i-j*3] = nums[i];
            
            if ((i+1) % 3 == 0)
            {
                j++;
            }
        }
        
        return resultArray;
    }
}