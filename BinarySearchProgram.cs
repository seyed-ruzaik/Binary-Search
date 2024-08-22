
using System;

class BinarySearch
{
    public int Search(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if target is present at mid
            if (array[mid] == target)
                return mid;

            // If target greater, ignore left half
            if (array[mid] < target)
                left = mid + 1;

            // If target is smaller, ignore right half
            else
                right = mid - 1;
        }

        // Target not present
        return -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinarySearch binarySearch = new BinarySearch();

        int[] array = { 2, 3, 4, 10, 40 };
        int target = 10;
        int result = binarySearch.Search(array, target);

        if (result == -1)
            Console.WriteLine("Element not present in array");
        else
            Console.WriteLine("Element found at index " + result);
    }
}
