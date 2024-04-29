namespace _001_RemoveDuplicatesFromSortedArray;

internal class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var count = 0;
        var index = 0;

        for (var compareIndex = 1; compareIndex < nums.Length; compareIndex++)
        {
            if (nums[index] == nums[compareIndex])
            {
                continue;
            }

            index++;
            nums[index] = nums[compareIndex];
            count++;
        }
        return index + 1;
    }
}
