using System.Text.RegularExpressions;
Console.WriteLine(Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
string Disemvowel(string str)
{    
    return Regex.Replace(str,@"([aeiouAEIOU]+)",r => "");
}