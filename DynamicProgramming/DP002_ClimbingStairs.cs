namespace DynamicProgramming;

/*
1 => 1
2 => 1 1, 2
3 => 1 1 1, 1 2, 2 1
4 => 1 1 1 1, 1 1 2, 1 2 1, 2 1 1, 2 2
*/

public class DP002_ClimbingStairs
{
    public int ClimbStairs(int n)
    {
        var memo = new int[n + 1];

        if (n == 0)
        {
            return 0;
        }

        memo[0] = 1;
        memo[1] = 2;

        for (int i = 2; i <= n; i++)
        {
            memo[i] = memo[i - 1] + memo[i - 2];
        }

        return memo[n - 1];
    }
}
