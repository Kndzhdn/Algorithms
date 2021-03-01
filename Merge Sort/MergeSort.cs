public List<double> MergeSort(List<double> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            var center = list.Count / 2;
            
            var leftPart = list.GetRange(0, center);
            var rightPart = list.GetRange(center, list.Count - center);

            leftPart = MergeSort(leftPart); 
            rightPart = MergeSort(rightPart);

            return Merge(leftPart, rightPart);
        }

private static List<double> Merge(List<double> leftPart, List<double> rightPart)
{
    var resultList = new List<double>();
    
    while (leftPart.Count != 0 && rightPart.Count != 0)
    {
        if (leftPart[0] < rightPart[0])
        {
            resultList.Add(leftPart[0]);
            leftPart.Remove(leftPart[0]);
        }
        else
        {
            resultList.Add(rightPart[0]);
            rightPart.Remove(rightPart[0]);
        }
    }

    if (leftPart.Count == 0)
    {
        for (var i = 0; i < rightPart.Count; i++)
        {
            resultList.Add(rightPart[i]);
        }
    }
    else
    {
        for (var i = 0; i < leftPart.Count; i++)
        {
            resultList.Add(leftPart[i]);
        }
    }

    return resultList;
}