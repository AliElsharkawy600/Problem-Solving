public class Solution {
    public int SingleNumber(int[] nums) {
        int finder = 0;

        for(short i = 0 ; i < nums.Length ; i++)
        {
            finder ^= nums[i];
        }
        return finder;
    }