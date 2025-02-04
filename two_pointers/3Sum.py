from dataclasses import dataclass


# THIS isnt the best solution.
@dataclass
class Item:
    index1: int
    index2: int


class Solution:
    def threeSum(self, nums: list[int]) -> list[list[int]]:
        m: dict[str, list[Item]] = {}
        i = 0
        while i < len(nums):
            j = i + 1
            while j < len(nums):
                key = nums[i] + nums[j]
                if key not in m:
                    m[key] = list()
                m[key].append(Item(i, j))
                j += 1
            i += 1

        answer: list[int] = list()
        answerExists: dict = {}
        for i, n in enumerate(nums):
            if (n * -1) in m:
                for item in m[(n * -1)]:
                    if item.index1 != i and item.index2 != i:
                        answerItem = sorted(
                            [nums[item.index1], nums[item.index2], nums[i]],
                        )
                        key = tuple(answerItem)
                        if key not in answerExists:
                            answerExists[key] = True
                            answer.append(answerItem)
        return list(answer)


def main():
    my_object = Solution()
    message = my_object.threeSum(nums=[-1, 0, 1, 2, -1, -4])
    print(message)  # [[-1,-1,2],[-1,0,1]]
    message = my_object.threeSum(nums=[0, 1, 1])
    print(message)  # []
    message = my_object.threeSum(nums=[0, 0, 0])
    print(message)  # [[0,0,0]]


if __name__ == "__main__":
    main()
