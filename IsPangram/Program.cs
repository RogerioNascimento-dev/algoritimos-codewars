using System.Text.RegularExpressions;
using System.Linq;
Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));

bool IsPangram(string str)
{
    /* Retorno decomposto;    
    var matches = Regex.Matches(str, @"[a-zA-Z]+");
    var resumido = String.Join("", matches);
    var minusculo = resumido.ToLower();
    var distincted = minusculo.OrderBy(e =>e).Distinct();    
    var TotalDistincted = distincted.Count();
    return true;
    */
    return String.Join("", Regex.Matches(str, @"[a-zA-Z]+")).ToLower().Distinct().Count() == 26;
}