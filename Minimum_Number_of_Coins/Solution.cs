public class Solution
{
    public int MinCoinsForChange(int[] denominations, int targetAmount)
    {
        int[] dp = new int[targetAmount + 1];
        for (int i = 1; i <= targetAmount; i++)
        {
            dp[i] = int.MaxValue;
        }
        dp[0] = 0;

        foreach (int coin in denominations)
        {
            for (int amount = coin; amount <= targetAmount; amount++)
            {
                if (dp[amount - coin] != int.MaxValue)
                {
                    dp[amount] = Math.Min(dp[amount], dp[amount - coin] + 1);
                }
            }
        }

        return dp[targetAmount] == int.MaxValue ? -1 : dp[targetAmount];
    }
}
