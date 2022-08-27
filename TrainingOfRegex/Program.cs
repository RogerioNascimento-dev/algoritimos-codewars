using System.Text.RegularExpressions;

void Training(string data)
{
    var rgx = new Regex(@"Dia (\d{2})\/(\d{2})\/(\d{4})");    
    var primeiro = rgx.Match(data);
    var Encontrados = rgx.Matches(data);
}


Training(@"
Dia 27/01/2022
Komum Tecnologia
Lauro de Freitas — Full Stack Developer
Nesta empresa trabalhei com a stack de PHP nativo no backend, HTML5, CSS3 e JQuery no Frontend em um software de gestão de franquias.
OUT DE 2017 - NOV DE 2018

Dia 22/12/2021
ENECAD
Lauro de Freitas — Full Stack Developer
Nesta empresa trabalhei com a stack de PHP nativo no backend, HTML5, CSS3 e JQuery no Frontend em um software de gestão de franquias.
OUT DE 2017 - NOV DE 2018");