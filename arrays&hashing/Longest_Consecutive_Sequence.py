# had some help with the idea to use a set from answers
class Solution:
    def longestConsecutive(self, nums: list[int]) -> int:
        maxH = 0
        s = set(nums)
        for val in s:
            if val - 1 not in s:
                tempH = 0
                tempVal = val
                while tempVal in s:
                    tempVal += 1
                    tempH += 1
                if tempH > maxH:
                    maxH = tempH
        return maxH


def main():
    my_object = Solution()
    message = my_object.longestConsecutive(nums=[2, 20, 4, 10, 3, 4, 5])
    print(message)  # 4
    message = my_object.longestConsecutive(nums=[0, 3, 2, 5, 4, 6, 1, 1])
    print(message)  # 7


if __name__ == "__main__":
    main()
