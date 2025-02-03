class Solution:
    def twoSum(self, numbers: list[int], target: int) -> list[int]:
        i = 0
        j = len(numbers) - 1
        while i < j:
            sum = numbers[i] + numbers[j]
            if sum == target:
                break
            if sum < target:
                i += 1
            else:
                j -= 1

        return [1 + i, 1 + j]


def main():
    my_object = Solution()

    message = my_object.twoSum(numbers=[1, 2, 3, 4], target=3)
    print(message)
    # message = my_object.twoSum(s="tab a cat")
    # print(message)


if __name__ == "__main__":
    main()
