def merge_sort(arr):
    if len(arr) <= 1:
        return arr
    
    center = len(arr) // 2
    left_part = arr[:center]
    right_part = arr[center:]
    
    left_part = merge_sort(left_part)
    right_part = merge_sort(right_part)
    
    return list(merge(left_part, right_part))





def merge(left_part, right_part):
    res = []
    
    while len(left_part) != 0 and len(right_part) != 0:
        if left_part[0] < right_part[0]:
            res.append(left_part[0])
            left_part.remove(left_part[0])
        else:
            res.append(right_part[0])
            right_part.remove(right_part[0])
    
    if len(left_part) == 0:
        res += right_part
    else:
        res += left_part
    
    return res




array = [12, 34, 25, 15, 67, 23, 11, 5, 86]
print("Initial array: ", array)

result_array = merge_sort(array)
print("Result array: ", result_array)