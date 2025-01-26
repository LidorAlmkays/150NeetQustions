class Solution:
    def hasDuplicate(self, nums: list[int]) -> bool:
        h = {}
        for num in nums:
            if num in h:
                return True
            else:
                h[num] = True
        return False


def main():
    my_object = Solution()
    message = my_object.hasDuplicate([1, 2, 3, 3])
    print(message)
    message = my_object.hasDuplicate([1, 2, 3, 4])
    print(message)
    message = my_object.hasDuplicate([1, 4, 2, 3, 4])
    print(message)


if __name__ == "__main__":
    main()
