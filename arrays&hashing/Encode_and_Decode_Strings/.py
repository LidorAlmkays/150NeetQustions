class Solution:

    def encode(self, strs: list[str]) -> str:
        resultStr: str = ""
        for word in strs:
            resultStr = resultStr + "" + str(len(word)) + "!"
            resultStr = resultStr + word
        return resultStr

    def decode(self, s: str) -> list[str]:
        index: int = 0
        result: list[str] = list[str]()
        while index < len(s):
            wordLengthInStr = ""
            while s[index] != "!":
                wordLengthInStr = wordLengthInStr + s[index]
                index += 1
            index += 1
            wordLength = int(wordLengthInStr) + index
            currentWord = ""
            while index < wordLength:
                currentWord = currentWord + s[index]
                index += 1
            result.append(currentWord)
        return result


def main():
    my_object = Solution()
    message = my_object.encode(["neet", "code", "love", "you"])
    print(message)
    message = my_object.decode(my_object.encode(["neet", "code", "love", "you"]))
    print(message)
    message = my_object.encode(["we", "say", ":", "yes"])
    print(message)
    message = my_object.decode(my_object.encode(["we", "say", ":", "yes"]))
    print(message)


if __name__ == "__main__":
    main()
