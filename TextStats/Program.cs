using TextStats.Entities;
using System.Text.RegularExpressions;
using System.Text.Json;


Stats TextStats(string document)
{
    if (document == null)
        throw new ArgumentNullException();

    Stats stats = new Stats();

    stats.NumberOfAllWords = document.Split(' ').Where(s => s != "").Count();
    stats.NumberOfWordsThatContainOnlyDigits = document.Split(' ').Where(s => s != "").Where(s => Regex.IsMatch(s, @"^[0-9]+$")).Count();
    stats.NumberOfWordsStartingWithSmallLetter = document.Split(' ').Where(s => s != "").Where(s => char.IsLower(s[0])).Count();
    stats.NumberOfWordsStartingWithCapitalLetter = document.Split(' ').Where(s => s != "").Where(s => char.IsUpper(s[0])).Count();
    stats.TheLongestWord = document.Split(' ').Where(s => s != "").GroupBy(s => s.Length).OrderByDescending(s => s.Key).Select(s => s.First()).FirstOrDefault();
    stats.TheShortestWord = document.Split(' ').Where(s => s != "").GroupBy(s => s.Length).OrderBy(s => s.Key).Select(s => s.First()).FirstOrDefault();
    
    return stats;
}

Console.WriteLine(JsonSerializer.Serialize(TextStats("testando PEIXE BOLA E GATO")));