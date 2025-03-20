using System;

namespace TwoPointer.Easy;

public class PairWithTargetSumBinarySearch
{
    public int[] findPair(int[] nums, int target)
    {
        int[] result = [-1, -1];

        if (nums == null || nums.Length < 2)
        {
            return result;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int start = i;
            int reminder = target - nums[start];
            int secondIndex = find(nums, reminder);
            if (secondIndex != -1 && secondIndex != start)
            {
                result = [start, secondIndex];
                return result;
            }
        }
        return result;
    }

    private int find(int[] nums, int reminder)
    {
        int start = 0;
        int end = nums.Length - 1;
        while (start < end)
        {
            int mid = start + (end - start) / 2;
            int possibleTarget = nums[mid];
            if (possibleTarget == reminder)
            {
                return mid;
            }
            if (possibleTarget < reminder)
            {
                start++;
            }
            else
            {
                end--;
            }
        }
        return -1;
    }

}
