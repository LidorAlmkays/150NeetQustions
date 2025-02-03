class Solution:
    def groupAnagrams(self, strs: list[str]) -> list[list[str]]:
        my_dict = {}
        groupCounter = 0
        for i, word in enumerate(strs):
            key = "".join(
                chr(ord("a") + l) + str(num)
                for l, num in enumerate(self.convertToCountingSmallLetters(word))
            )
            if key not in my_dict:
                my_dict[key] = set()
                groupCounter += 1
            my_dict[key].add(i)
            i += 1

        result = [[str]] * groupCounter

        for i, key in enumerate(my_dict):
            result[i] = [""] * len(my_dict[key])
            for j, itemIndex in enumerate(my_dict[key]):
                result[i][j] = strs[itemIndex]
            i += 1
        return result

    def convertToCountingSmallLetters(self, word: str) -> list[int]:
        array = [0] * 26
        for c in word:
            array[ord(c) - ord("a")] += 1
        return array


def main():
    my_object = Solution()

    message = my_object.groupAnagrams(
        strs=["act", "pots", "tops", "cat", "stop", "stop", "hat"]
    )
    print(message)
    message = my_object.groupAnagrams(["x", "x"])
    print(message)
    message = my_object.groupAnagrams(strs=[""])
    print(message)
    message = my_object.groupAnagrams(strs=["bdddddddddd", "bbbbbbbbbbc"])
    print(message)


if __name__ == "__main__":
    main()
