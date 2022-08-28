Console.WriteLine(String.Join(", ", OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } })));

IEnumerable<string> OpenOrSenior(int[][] data)
{
    return data.Select(user => user[0] >= 55 && user[1] > 7 ? "Senior" : "Open").ToList();
}