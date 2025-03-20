using System;

namespace TwoPointer.Easy;

public class PairwithTargetSum
{
    public int[] FindPair(int[] nums, int target)
    {
        int[] result = [-1,-1];
        if(nums==null || nums.Length<2)
        {
            return result;
        }

        int start = 0;
        int end = nums.Length-1;
        while(start<end)
        {
            int possibleSum = nums[start] + nums[end];
            if(possibleSum==target)
            {
                result = [start,end];
                return result; // have to check to update the result value
            }
            if(possibleSum>target)
            {
                end--;
            }
            else
            {
                start++;
            }
        }
        return result;

    }
}
