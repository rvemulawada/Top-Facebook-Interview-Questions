//Link to Leetcode Problem - https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

public int[] SearchRange(int[] a, int target)
{
    int[] result = { -1, -1 };

    if (a == null || a.Length == 0)
        return result;

    result[0] = FindStartPosition(a, target);
    result[1] = FindEndPosition(a, target);

    return result;
}

public int FindStartPosition(int[] a, int target)
{
    int left = 0;
    int right = a.Length - 1;
    int start = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (a[mid] == target)
        {
            start = mid; // this is start
            right = mid - 1; // let's see if there is one more on the left
        }
        else if (target > a[mid])
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return start;
}

public int FindEndPosition(int[] a, int target)
{
    int left = 0;
    int right = a.Length - 1;
    int end = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (a[mid] == target)
        {
            end = mid; // this is the end
            left = mid + 1; // let's see if there is one more on the right
        }
        else if (target > a[mid])
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return end;
}
