namespace TopInterviewQuestions;

// Given an integer array nums sorted in non-decreasing order,
// remove the duplicates in-place such that each unique element
// appears only once. The relative order of the elements should
// be kept the same. Then return the number of unique elements
// in nums.

// Consider the number of unique elements of nums to be k, to
// get accepted, you need to do the following things:
//  * Change the array nums such that the first k elements of
//   nums contain the unique elements in the order they were
//   present in nums initially.The remaining elements of nums
//   are not important as well as the size of nums.
//  * Return k.

public class L001_RemoveDuplicatesFromSortedArray
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
