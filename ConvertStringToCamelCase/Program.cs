using System.Linq;
using System.Text.RegularExpressions;

Console.WriteLine(ToCamelCase("the-stealth-warrior"));
Console.WriteLine(ToCamelCaseCodeWars("the-stealth-warrior"));
string ToCamelCase(string str)
{

    
    char[] ArrayStr = str.ToCharArray();

    foreach(var New in str.Select((value, index) => new { value, index }))
    {
        if (New.value == '-' || New.value == '_')        
            ArrayStr[New.index +1] = char.ToUpper(ArrayStr[New.index + 1]);       
            
    }
    return new String(ArrayStr).Replace("-","").Replace("_","");        
    
}

//Solução da plataforma
string ToCamelCaseCodeWars(string str)
{
    return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
}