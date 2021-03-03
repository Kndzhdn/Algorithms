private int BinarySearch(List<int> numbers, int searchValue)
{
    var left = 0;
    var right = numbers.Count;

    while (left < right)
    {
        var middle = (left + right) / 2;
        if (searchValue < numbers[middle])
        {
            right = middle;
        }
        else if (searchValue > numbers[middle])
        {
            left = middle;
        }
        else
        {
            return middle + 1;
        }
    }

    return -1;
}