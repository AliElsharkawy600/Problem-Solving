using System.Collections.Generic;
public class Solution 
{
    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        // using Dictionary<int, int> for type safety Unlike Hashtable 
        var nums1Map = new Dictionary<int, int>(); 
        //  using List<int> for type safety unlike ArrayList
        var intersectionList = new List<int>(); 

        // Add nums1 array to Dictionary and track frequency
        for(int i = 0; i < nums1.Length; i++)
        {
            if(nums1Map.ContainsKey(nums1[i]))
            {
                nums1Map[nums1[i]]++;
            }
            else
            {
                nums1Map[nums1[i]] = 1;
            }
        }

        // Check nums2 against nums1Map and build intersection
        for(int i = 0; i < nums2.Length; i++)
        {
            if(nums1Map.ContainsKey(nums2[i]) && nums1Map[nums2[i]] > 0)
            {
                intersectionList.Add(nums2[i]); 
                nums1Map[nums2[i]]--;
            }
        }

        // Convert List<int> to int[]
        int[] result = intersectionList.ToArray();

        return result;
    }
}