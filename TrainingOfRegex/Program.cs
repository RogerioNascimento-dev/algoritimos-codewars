using System.Text.RegularExpressions;

void Training(string data)
{
    var rgx = new Regex(@"Dia (\d{2})\/(\d{2})\/(\d+)");    
    var primeiro = rgx.Match(data);
    var Encontrados = rgx.Matches(data);


    string Url = "https://www.rogerionascimento.dev.br/skills/88";
    var rgxRota = new Regex(@"https://.*\.\w{2}\/(\w+)\/(.*)");
    var rgxRotaMatch = rgxRota.Match(Url);
    var rota = rgxRota.Replace(Url, e => e.Groups[1].Value);



    var a = "";
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