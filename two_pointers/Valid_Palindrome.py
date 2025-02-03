class Solution:
    def checkIfLetterIsValid(self, l: str) -> bool:
        return (ord(l) <= ord("z") and ord(l) >= ord("a")) or (
            ord(l) <= ord("9") and ord(l) >= ord("0")
        )

    def isPalindrome(self, s: str) -> bool:
        i: int = 0
        j: int = len(s) - 1
        temps: str = s.lower()
        while i <= j:
            if not self.checkIfLetterIsValid(temps[i]):
                i += 1
                continue
            if not self.checkIfLetterIsValid(temps[j]):
                j -= 1
                continue
            if temps[i] != temps[j]:
                return False
            i += 1
            j -= 1
        return True


def main():
    my_object = Solution()

    message = my_object.isPalindrome(s="Was it a car or a cat I saw?")
    print(message)  # true
    message = my_object.isPalindrome(s="tab a cat")
    print(message)  # false
    message = my_object.isPalindrome(s="ab")
    print(message)  # false
    message = my_object.isPalindrome(s="0P")
    print(message)  # false


if __name__ == "__main__":
    main()
