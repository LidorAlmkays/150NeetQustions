class Solution:
    def topKFrequent(self, nums: list[int], k: int) -> list[int]:
        result = [int] * k
        dic = {}
        for num in nums:
            if num not in dic:
                dic[num] = 0
            dic[num] += 1

        arr = [set()] * len(
            nums
        )  # this array indexs is the amout of times the number has been seen, and the value is the numbers.
        for i in range(len(nums)):
            arr[i] = set()

        for key in dic:
            arr[dic[key] - 1].add(key)
        flagStopKElementsFound = False
        for val in reversed(arr):
            for number in val:
                result[k - 1] = number
                k -= 1
                if k == 0:
                    flagStopKElementsFound = True
                    break  # Stops the loop when k is 0
            if flagStopKElementsFound:
                break
        return result


def main():
    my_object = Solution()
    message = my_object.topKFrequent(nums=[1, 2, 2, 3, 3, 3], k=2)
    print(message)
    message = my_object.topKFrequent(nums=[1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3], k=2)
    print(message)
    message = my_object.topKFrequent([7, 7], k=1)
    print(message)


if __name__ == "__main__":
    main()
