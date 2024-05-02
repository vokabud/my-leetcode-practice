namespace TopInterviewQuestions;

// Given an integer array nums, return true if any value appears
// at least twice in the array, and return false if every element is distinct.

public class L004_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        var duplicateNoticed = QuickSort(nums, 0, nums.Length - 1);

        if (duplicateNoticed)
        {
            return true;
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }

        return false;
    }

    public bool QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;

        var pivot = array[leftIndex];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                if (array[i] == pivot)
                {
                    return true;
                }

                i++;
            }

            while (array[j] > pivot)
            {
                if (array[j] == pivot)
                {
                    return true;
                }

                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
        {

            QuickSort(array, leftIndex, j);
        }

        if (i < rightIndex)
        {
            QuickSort(array, i, rightIndex);
        }

        return false;
    }
}
