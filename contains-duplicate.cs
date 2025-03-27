/*
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();

        for(int i =0 ; i < nums.Length ; i++)
        {
            if(numbers.Contains(nums[i]))
            {
                return true;
            }
            numbers.Add(nums[i]);
        }
        return false;
    }
}
*/
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var numbers = new HashSet<int>(nums.Length); // Preallocate capacity to avoid resizing

        foreach (int num in nums) // Use foreach for cleaner iteration
        {
            if (!numbers.Add(num)) // Add returns false if the item already exists
            {
                return true;
            }
        }
        return false;
    }
}