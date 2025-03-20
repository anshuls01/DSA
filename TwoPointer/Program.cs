// See https://aka.ms/new-console-template for more information
using TwoPointer.Easy;

Console.WriteLine("Two Pointer");

Console.WriteLine("Pair with Target Sum");
PairwithTargetSum pairwithTargetSum = new PairwithTargetSum();
#region PairWithTargetSum Test case
Console.WriteLine(string.Join(",", pairwithTargetSum.FindPair([1, 2, 3, 4, 6], 6)));
Console.WriteLine(string.Join(",", pairwithTargetSum.FindPair([2, 5, 9, 11], 11)));
Console.WriteLine(string.Join(",", pairwithTargetSum.FindPair([1, 3, 5, 7], 10)));
Console.WriteLine(string.Join(",", pairwithTargetSum.FindPair([], 5)));
#endregion
PairWithTargetSumBinarySearch pairWithTargetSumBinarySearch = new PairWithTargetSumBinarySearch();
int[] nums1 = { 1, 2, 3, 4, 6 };
int target1 = 6;
int[] result1 = pairWithTargetSumBinarySearch.findPair(nums1, target1);
Console.WriteLine($"Result: [{result1[0]}, {result1[1]}]"); // Expected: [1, 3]

#region PairWithTargetSumBinarySearch Test case
//test cases
int[] nums2 = { 2, 5, 9, 11 };
int target2 = 11;
int[] result2 = pairWithTargetSumBinarySearch.findPair(nums2, target2);
Console.WriteLine($"Result: [{result2[0]}, {result2[1]}]"); // Expected: [0, 2]

int[] nums3 = { 1, 3, 5, 7 };
int target3 = 10;
int[] result3 = pairWithTargetSumBinarySearch.findPair(nums3, target3);
Console.WriteLine($"Result: [{result3[0]}, {result3[1]}]"); // Expected: [3, 1]

int[] nums4 = { };
int target4 = 5;
int[] result4 = pairWithTargetSumBinarySearch.findPair(nums4, target4);
Console.WriteLine($"Result: [{result4[0]}, {result4[1]}]"); // Expected: [-1, -1]
#endregion