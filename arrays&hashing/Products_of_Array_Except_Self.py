class Solution:
    def productExceptSelf(self, nums: list[int]) -> list[int]:
        i = 0
        j = len(nums) - 1
        resultArr: list[int] = [1] * len(nums)
        multyL = 1
        multyR = 1
        while (i < len(nums)) and (j >= 0):
            resultArr[i] *= multyL
            resultArr[j] *= multyR
            multyL *= nums[i]
            multyR *= nums[j]
            i += 1
            j -= 1
        return resultArr


def main():
    my_object = Solution()
    message = my_object.productExceptSelf(nums=[1, 2, 4, 6])
    print(message)
    message = my_object.productExceptSelf(nums=[-1, 0, 1, 2, 3])
    print(message)


if __name__ == "__main__":
    main()
