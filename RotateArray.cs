public class Solution 
{
    public void Rotate(int[] nums, int k) 
    {
        // [1,2,3,4,5,6,7]   if k = 7 (bring the array back to original position) 
        // [5,6,7,1,2,3,4]
        // k = 3
        k = k % nums.Length;

        // Reverse the entire array
        // [1,2,3,4,5,6,7] -> [7,6,5,4,3,2,1]
        reverse(nums, 0, (nums.Length -1));

        // Reverse frist k elements
        // [7,6,5,4,3,2,1] -> [5,6,7,4,3,2,1]
        reverse(nums, 0, k-1);

        // Reverse the last nums.Length - k elements
        //[5,6,7,4,3,2,1] -> [5,6,7,1,2,3,4]
        reverse(nums, k, (nums.Length -1));

    }
    public void reverse(int[] nums, int start, int end)
    {
        while(start < end)
        {
            nums[start] = nums[end] + nums[start];
            nums[end] = nums[start] - nums[end];
            nums[start] = nums[start] - nums[end];
            start++;
            end--;
        }
    }
}