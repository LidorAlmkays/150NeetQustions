class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        h = {}
        if len(s) != len(t):
            return False
        for c in s:
            if c in h:
                h[c] += 1
            else:
                h[c] = 1
        for c in t:
            if (not c in h) or h[c] == 0:
                return False
            else:
                h[c] -= 1
        return True


def main():
    my_object = Solution()

    message = my_object.isAnagram(s="xx", t="x")
    print(message)
    message = my_object.isAnagram(s="mjar", t="jamr")
    print(message)
    message = my_object.isAnagram(s="jar", t="jam")
    print(message)
    message = my_object.isAnagram(s="racecar", t="carrace")
    print(message)


if __name__ == "__main__":
    main()
