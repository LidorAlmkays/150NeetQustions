class Solution:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        h = {}
        for i in range(len(nums)):

            if target - nums[i] in h:
                if i < h[target - nums[i]]:
                    return [i, target - nums[i]]
                return [h[target - nums[i]], i]
            else:
                h[nums[i]] = i
        return [-1, -1]


def main():
    my_object = Solution()

    message = my_object.twoSum(nums=[-1, -2, -3, -4, -5], target=-8)
    print(message)
    message = my_object.twoSum(nums=[3, 4, 5, 6], target=7)
    print(message)
    message = my_object.twoSum(nums=[4, 5, 6], target=10)
    print(message)
    message = my_object.twoSum(nums=[5, 5], target=10)
    print(message)


if __name__ == "__main__":
    main()
