using System;

namespace TwoPointer.Easy;

public class PairWithTargetSumHashMap
{
    public int[] FindPair(int[] nums, int target)
    {
        if (nums == null || nums.Length < 2)
        {
            return [-1, -1];
        }

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int reminder = target - nums[i];
            if (map.ContainsKey(reminder))
            {
                return [i, map[reminder]];
            }

            map[nums[i]] = i;
        }
        return  [-1,-1];
    }

}
