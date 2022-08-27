string RepeatedLetters(string A)
{
    string found = null;
    foreach (var New in A.Select((value, index) => new { value, index }))
    {

        if (found == null && A.Any(ale => ale == New.value) && isDifferentIndex(A, New.value, New.index))
        {
            found = New.value.ToString();
        }
    }
    found = found == null ? A[0].ToString() : found;
    return found;
}

bool isDifferentIndex(string A, char value, int currentindex)
{
    int foundIndex = Array.IndexOf(A.ToCharArray(), value);
    return foundIndex != currentindex;
}

Console.WriteLine(RepeatedLetters("hello"));
