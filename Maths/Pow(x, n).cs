//Link to Leetcode Problem: https://leetcode.com/problems/powx-n/

public double MyPow(double x, int n) {
    // Base case: if n is 0, return 1.0
    if (n == 0) return 1.0;

    // Recursively calculate the result for half of the exponent
    double result = MyPow(x, n / 2);
    result *= result; // Square the result

    // For odd exponents, multiply the result by x
    if (n % 2 != 0) {
        if (n > 0) {
            result *= x;
        } else {
            // For negative odd exponents, divide the result by x
            result /= x;
        }
    }

    // Return the calculated result
    return result;
}
