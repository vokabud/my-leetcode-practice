namespace DynamicProgramming;

public class DP001_Fibonacci
{
    private Dictionary<int, int> _memo { get; set; } = new Dictionary<int, int>
    {
        { 0, 0 },
        { 1, 1 }
    };

    public int Fibonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Input must be a non-negative integer.");
        }

        if (_memo.ContainsKey(n))
        {
            return _memo[n];
        }

        for (int i = 2; i <= n; i++)
        {
            _memo[i] = _memo[i - 1] + _memo[i - 2];
        }

        return _memo[n];
    }
}
