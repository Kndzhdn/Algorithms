def binary_search(xs, query):
    left, right = 0, len(xs)-1
    while left <= right:
        middle = (left+right) // 2
        if query < xs[middle]:
            right = middle - 1
        elif query > xs[middle]:
            left = middle + 1
        else:
            return middle + 1
            
    return -1


xs = [1, 5, 8, 12, 13]
query = 12
print(find_pos(xs, query))