



string interval = "";
string controlInterval = "C";
List<string> intervals = new List<string>();


Console.WriteLine(BinaryInterval(1041));

int BinaryInterval(int N)
{
    string binary = Convert.ToString(N, 2);

    foreach (var New in binary.Select((value, index) => new { value, index }))
    {
        if (New.value == '1' && controlInterval == "C")
        {
            OpenInterval();
            continue;
        }
        if (New.value == '1' && controlInterval == "O")
        {
            CloseInterval();
            continue;
        }
        if (New.value == '0')
        {
            interval += New.value;
            continue;
        }
    }

    var final = intervals.Count() > 0 ? intervals.Max().Length : 0;
    return final;
}

void OpenInterval()
{
    if (interval != "")
        intervals.Add(interval);

    interval = "";
    controlInterval = "O";
}

void CloseInterval()
{
    if (interval != "")
        intervals.Add(interval);
    controlInterval = "C";
    interval = "";
}