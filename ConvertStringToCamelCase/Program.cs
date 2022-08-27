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
    // a expressão regular da matches com {-s} e {-w} por exempolo
    // retorna dois grupos para cada match no 0 é toda expressão ou seja {-s}
    // e no grupo 1 retorna oq foi pedido na expressão através dos (), o primeiro caractere depois do - ou _
    // no final das contas a leitura desse retorno fica da seguinte forma.
    // Para cada uma correspondência dessa expressão regular (-w), subistitua por o group na posição 1
    // em Maiúsculo neste caso troca-se -w por W.
    return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
}