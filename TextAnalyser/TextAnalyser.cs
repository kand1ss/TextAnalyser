
public class TextAnalyser
{
    private readonly string _text;
    private readonly string[] _words;

    private readonly char[] textSplitters = [' ', ',', '.', '!', '?', ';', ':', '\n', '\t'];

    public TextAnalyser(string textForAnalysis)
    {
        _text = textForAnalysis.ToLower();
        _words = _text.Split(textSplitters, StringSplitOptions.RemoveEmptyEntries);
    }
    
    public int GetWordCount() => _words.Length;
    public int GetUniqueWordCount() => _words.Distinct().Count();
    public double GetAverageWordLength() => _words.Average(w => w.Length);

    public int GetSymbolsCount() => _text.Length;

    public int GetSentencesCount()
    {
        var sentenceSplitters = new[] { '.', '!', '?' };
        return _text.Split(sentenceSplitters, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public string GetMostCommonlyUsedWord()
    {
        if (_words.Length == 0)
            return "";
        
        return _words
            .GroupBy(word => word)
            .OrderByDescending(group => group.Count())
            .First().Key;
    }
    
    public string GetLongestWord()
    {
        if (_words.Length == 0)
            return "";
        
        return _words
            .OrderByDescending(word => word.Length)
            .First();
    }

    public string GetShortestWord()
    {
        if (_words.Length == 0)
            return "";
        
        return _words
            .OrderBy(word => word.Length)
            .First();
    }

    public int GetNumberOfRepetitions(string particularWord, bool ignoreCase = true)
    {
        return _words.Count(word => ignoreCase
            ? word == particularWord.ToLower()
            : word == particularWord);
    }
}