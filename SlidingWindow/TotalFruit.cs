//Link to Leetcode Problems: https://leetcode.com/problems/fruit-into-baskets/description/

public int TotalFruit(int[] fruits) {
    int windowStart = 0, maxFruits = 0;
    Dictionary<int, int> fruitsBasket = new Dictionary<int, int>(); // Store fruit types and their counts

    for (int windowEnd = 0; windowEnd < fruits.Length; windowEnd++) {
        // Expand the sliding window
        int currentFruit = fruits[windowEnd];

        // Add/update the fruit type and its count in the basket
        fruitsBasket[currentFruit] = fruitsBasket.GetValueOrDefault(currentFruit) + 1;

        // Adjust the window size if the number of distinct fruits exceeds 2
        while (fruitsBasket.Count > 2) {
            int leftFruit = fruits[windowStart];
            fruitsBasket[leftFruit]--; // Shrink the window
            if (fruitsBasket[leftFruit] == 0) {
                fruitsBasket.Remove(leftFruit);
            }
            windowStart++;
        }

        // Calculate the maximum number of fruits within the window
        maxFruits = Math.Max(maxFruits, windowEnd - windowStart + 1);
    }
    return maxFruits;
}
