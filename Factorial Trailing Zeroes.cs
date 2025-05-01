public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        int currPowerOfFive = 5;

        while(n>=currPowerOfFive){
            count += (n / currPowerOfFive);
            currPowerOfFive *= 5;
        }
        return count;
    }
}