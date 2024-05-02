namespace TopInterviewQuestions;

// Given a non-empty array of integers nums, every element
// appears twice except for one. Find that single one.

// You must implement a solution with a linear runtime
// complexity and use only constant extra space.

// Constraints:
//  * 1 <= nums.length <= 3 * 104
//  * -3 * 10^4 <= nums[i] <= 3 * 10^4
//  * Each element in the array appears twice
//    except for one element which appears only once.


public class L005_SingleNumber
{
    public int SingleNumber(int[] nums)
    {
        var testArray = PrepareArray();

        for (int i = 0; i < nums.Length; i++)
        {
            testArray[nums[i] + 30000]++;
        }

        for (int i = 0; i < testArray.Length; i++)
        {
            if (testArray[i] == 1)
            {
                return i - 30000;
            }
        }

        return 0;
    }

    private int[] PrepareArray()
    {
        var result = new int[3 * 2 * 10000];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        return result;
    }
}
