class Solution(object):
    def gcdOfStrings(self, str1, str2):
        """
        :type str1: str
        :type str2: str
        :rtype: str
        """
        # Check if strings can be divided by a common string
        if str1 + str2 != str2 + str1:
            return ""
        
        # Find GCD of string lengths using Euclidean algorithm
        def gcd(a, b):
            while b:
                a, b = b, a % b
            return a
        
        # Return the substring with length of GCD
        gcd_length = gcd(len(str1), len(str2))
        return str1[:gcd_length]

# Test the solution
def test_solution():
    solution = Solution()
    
    # Test cases
    test_cases = [
        ("ABCABC", "ABC", "ABC"),
        ("ABABAB", "ABAB", "AB"),
        ("LEET", "CODE", ""),
    ]
    
    for str1, str2, expected in test_cases:
        result = solution.gcdOfStrings(str1, str2)
        print("Input: str1 = {0}, str2 = {1}".format(str1, str2))
        print("Output: {0}".format(result))
        print("Expected: {0}".format(expected))
        print("Test passed!" if result == expected else "Test failed!")
        print("")

if __name__ == "__main__":
    test_solution()
