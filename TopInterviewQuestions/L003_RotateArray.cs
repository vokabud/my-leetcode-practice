namespace TopInterviewQuestions;

// Given an integer array nums, rotate the array to the right
// by k steps, where k is non-negative.

public class L003_RotateArray
{
    public int[] Rotate(int[] nums, int k)
    {
        if (nums.Length == 0 || nums.Length == k)
        {
            return nums;
        }

        if (k > nums.Length)
        {
            k = k % nums.Length;
        }

        if (k == 0)
        {
            return nums;
        }

        Revers(nums, 0, nums.Length - 1);

        Revers(nums, 0, k - 1);

        Revers(nums, k, nums.Length - 1);

        return nums;

    }

    private void Revers(int[] nums, int start, int end)
    {
        var mid = (end - start) / 2;

        for (int i = 0; i <= mid; i++)
        {
            Swap(nums, start + i, end - i);
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
