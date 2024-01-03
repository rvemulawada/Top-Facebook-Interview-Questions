//Link to Leetcode Problem : https://leetcode.com/problems/contains-duplicate/description/

public bool ContainsDuplicate(int[] nums)
{
    // Check if the input array is null or empty
    if (nums == null || nums.Length == 0)
        return false; // If it is, there are no duplicates

    // Create a HashSet to store unique elements from the input array
    HashSet<int> set = new HashSet<int>(nums);

    // If the number of unique elements in the set is less than the total number of elements in 'nums',
    // it means there are duplicates, as some elements were not added to the set (HashSet cannot contain duplicates)
    return set.Count < nums.Length;
}
