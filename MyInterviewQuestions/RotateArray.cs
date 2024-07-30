namespace MyInterviewQuestions;

// Given a two-dimentional integer array. Rotate the array 90 degrees clockwise.

// Input:
//      1 2 3
//      4 5 6
//      7 8 9
// 
// Output:
//      7 4 1
//      8 5 2
//      9 6 3
// 

// Constraints:
//  * You must rotate the array in-place, which means you have to modify the input 2D array directly.
//  * DO NOT allocate another 2D array and do the rotation.
//  * Matrix must be square (n x n)

// Solution:
// Use recursion, and rotate the array layer by layer.

public class RotateArray
{
    public int[,] Rotate(int[,] nums)
    {
        if (nums.Length == 0)
        {
            return nums;
        }

        RotateLayer(nums, 0, nums.GetLength(0) - 1);

        return nums;
    }

    private void RotateLayer(int[,] nums, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        // for a square, it is always the same number of vertexes
        // and we should perform the same number of swaps for each number
        //
        // 1 2 3
        // 4 5 6
        // 7 8 9
        // 
        // 1 -> 3, 3 -> 9, 9 -> 7, 7 -> 1
        // 2 -> 6, 6 -> 8, 8 -> 4, 4 -> 2
        //
        // so, we should do the same sequance of swaps
        // for each number in first row except the last one

        for (int i = 0; i < end - start; i++)
        {
            var topRightY = start;
            var topRightX = start + i;
            var bottomRightY = end - i;
            var bottomRightX = start;
            var bottomLeftY = end;
            var bottomLeftX = end - i;
            var topLeftY = start + i;
            var topLeftX = end;

            var temp = nums[topRightY, topRightX];

            nums[topRightY, topRightX] = nums[bottomRightY, bottomRightX];
            nums[bottomRightY, bottomRightX] = nums[bottomLeftY, bottomLeftX];
            nums[bottomLeftY, bottomLeftX] = nums[topLeftY, topLeftX];
            nums[topLeftY, topLeftX] = temp;
        }

        // rotate the next layer
        // for example for 4x4 matrix
        //
        //       1  2  3  4
        //       5  6  7  8
        //       9 10 11 12
        //      13 14 15 16
        //
        // we should rotate the inner matrix   
        //
        //       6  7
        //      10 11
        RotateLayer(nums, start + 1, end - 1);
    }
}
