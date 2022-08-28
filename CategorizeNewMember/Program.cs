
OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });
IEnumerable<string> OpenOrSenior(int[][] data)
{
    List<string> response = new List<string>();
    foreach (var i in data)
    {
        if (i[0] >= 55 && i[1] > 7)
            response.Add("Senior");
        else
            response.Add("Open");
    }
    return response;
}