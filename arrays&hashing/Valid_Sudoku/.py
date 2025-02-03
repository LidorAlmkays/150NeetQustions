from dataclasses import dataclass


@dataclass
class Item:
    col: map
    row: map
    sections: map


class Solution:
    def isValidSudoku(self, board: list[list[str]]) -> bool:
        items: dict[str, Item] = {}
        for i, l in enumerate(board):
            for j, w in enumerate(l):
                if w != ".":
                    if w in items:
                        if (
                            i in items[w].row
                            or j in items[w].col
                            or (int(i / 3), int(j / 3)) in items[w].sections
                        ):
                            return False
                    else:
                        items[w] = Item({}, {}, {})
                    items[w].col[j] = True
                    items[w].row[i] = True
                    items[w].sections[(int(i / 3), int(j / 3))] = True
        return True


def main():
    my_object = Solution()
    message = my_object.isValidSudoku(
        board=[
            ["1", "2", ".", ".", "3", ".", ".", ".", "."],
            ["4", ".", ".", "5", ".", ".", ".", ".", "."],
            [".", "9", "8", ".", ".", ".", ".", ".", "3"],
            ["5", ".", ".", ".", "6", ".", ".", ".", "4"],
            [".", ".", ".", "8", ".", "3", ".", ".", "5"],
            ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
            [".", ".", ".", ".", ".", ".", "2", ".", "."],
            [".", ".", ".", "4", "1", "9", ".", ".", "8"],
            [".", ".", ".", ".", "8", ".", ".", "7", "9"],
        ]
    )
    print(message)
    message = my_object.isValidSudoku(
        board=[
            ["1", "2", ".", ".", "3", ".", ".", ".", "."],
            ["4", ".", ".", "5", ".", ".", ".", ".", "."],
            [".", "9", "1", ".", ".", ".", ".", ".", "3"],
            ["5", ".", ".", ".", "6", ".", ".", ".", "4"],
            [".", ".", ".", "8", ".", "3", ".", ".", "5"],
            ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
            [".", ".", ".", ".", ".", ".", "2", ".", "."],
            [".", ".", ".", "4", "1", "9", ".", ".", "8"],
            [".", ".", ".", ".", "8", ".", ".", "7", "9"],
        ]
    )
    print(message)


if __name__ == "__main__":
    main()
