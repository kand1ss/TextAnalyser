using Xunit;

public class TextAnalyserTests
{
    readonly string simpleText = "Hello world! This is a simple test.";
    readonly string emptyText = "";
    readonly string repetitiveText = "Word word word, word word.";
    readonly string textWithManySentences = "Hello there! How are you? I am fine.";
    readonly string textWithTabulationAndOffset = "This is a line.\nAnd this is another line.\tAnd here is a tab.";
    readonly string textWithDifferentCharacterCase = "test Test TEST tEsT TeSt";
    
    [Fact]
    public void GetWordCount_simpleText_ReturnsCorrectNumberOfWords()
    {
        var textAnalyser = new TextAnalyser(simpleText);
        int wordCount = textAnalyser.GetWordCount();
        
        Assert.Equal(7, wordCount);
    }
    
    [Fact]
    public void GetWordCount_emptyText_ReturnsZeroNumberOfWords()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        int wordCount = textAnalyser.GetWordCount();
        
        Assert.Equal(0, wordCount);
    }
    
    [Fact]
    public void GetUniqueWordCount_simpleText_ReturnsCorrectNumberOfUniqueWords()
    {
        var textAnalyser = new TextAnalyser(simpleText);
        int uniqueWordCount = textAnalyser.GetUniqueWordCount();
        
        Assert.Equal(7, uniqueWordCount);
    }

    [Fact]
    public void GetUniqueWordCount_repetitiveText_ReturnsCorrectNumberOfUniqueWords()
    {
        var textAnalyser = new TextAnalyser(repetitiveText);
        int uniqueWordCount = textAnalyser.GetUniqueWordCount();
        
        Assert.Equal(1, uniqueWordCount);
    }
    
    [Fact]
    public void GetUniqueWordCount_emptyText_ReturnsZeroNumberOfUniqueWords()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        int uniqueWordCount = textAnalyser.GetUniqueWordCount();
        
        Assert.Equal(0, uniqueWordCount);
    }
    
    [Fact]
    public void GetSymbolsCount_simpleText_ReturnsCorrectNumberOfSymbols()
    {
        var textAnalyser = new TextAnalyser(simpleText);
        int symbolsCount = textAnalyser.GetSymbolsCount();
        
        Assert.Equal(35, symbolsCount);
    }
    
    [Fact]
    public void GetSymbolsCount_emptyText_ReturnsZeroNumberOfSymbols()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        int symbolsCount = textAnalyser.GetSymbolsCount();
        
        Assert.Equal(0, symbolsCount);
    }
    
    [Fact]
    public void GetSentencesCount_textWithManySentences_ReturnsCorrectNumberOfSentences()
    {
        var textAnalyser = new TextAnalyser(textWithManySentences);
        int sentencesCount = textAnalyser.GetSentencesCount();
        
        Assert.Equal(3, sentencesCount);
    }
    
    [Fact]
    public void GetSentencesCount_textWithTabulationAndOffset_ReturnsCorrectNumberOfSentences()
    {
        var textAnalyser = new TextAnalyser(textWithTabulationAndOffset);
        int sentencesCount = textAnalyser.GetSentencesCount();
        
        Assert.Equal(3, sentencesCount);
    }
    
    [Fact]
    public void GetSentencesCount_emptyText_ReturnsZeroNumberOfSentences()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        int sentencesCount = textAnalyser.GetSentencesCount();
        
        Assert.Equal(0, sentencesCount);
    }

    [Fact]
    public void GetMostCommonlyUsedWord_simpleText_ReturnsFirstWord()
    {
        var textAnalyser = new TextAnalyser(simpleText);
        string mostCommonlyUsedWord = textAnalyser.GetMostCommonlyUsedWord();
        
        Assert.Equal("hello", mostCommonlyUsedWord);
    }
    
    [Fact]
    public void GetMostCommonlyUsedWord_textWithDifferentCharacterCase_ReturnsFirstWord()
    {
        var textAnalyser = new TextAnalyser(textWithDifferentCharacterCase);
        string mostCommonlyUsedWord = textAnalyser.GetMostCommonlyUsedWord();
        
        Assert.Equal("test", mostCommonlyUsedWord);
    }
    
    [Fact]
    public void GetMostCommonlyUsedWord_repetitiveText_ReturnsFirstWord()
    {
        var textAnalyser = new TextAnalyser(repetitiveText);
        string mostCommonlyUsedWord = textAnalyser.GetMostCommonlyUsedWord();
        
        Assert.Equal("word", mostCommonlyUsedWord);
    }
    
    [Fact]
    public void GetMostCommonlyUsedWord_textWithTabulationAndOffset_ReturnsMostCommonlyUsedWord()
    {
        var textAnalyser = new TextAnalyser(textWithTabulationAndOffset);
        string mostCommonlyUsedWord = textAnalyser.GetMostCommonlyUsedWord();
        
        Assert.Equal("is", mostCommonlyUsedWord);
    }
    
    [Fact]
    public void GetMostCommonlyUsedWord_emptyText_ReturnsEmptyText()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        string mostCommonlyUsedWord = textAnalyser.GetMostCommonlyUsedWord();
        
        Assert.Equal("", mostCommonlyUsedWord);
    }

    [Fact]
    public void GetLongestWord_simpleText_ReturnsLongestWord()
    {
        var textAnalyser = new TextAnalyser(simpleText);
        string longestWord = textAnalyser.GetLongestWord();
        
        Assert.Equal("simple", longestWord);
    }
    
    [Fact]
    public void GetLongestWord_textWithTabulationAndOffset_ReturnsLongestWord()
    {
        var textAnalyser = new TextAnalyser(textWithTabulationAndOffset);
        string longestWord = textAnalyser.GetLongestWord();
        
        Assert.Equal("another", longestWord);
    }
    
    [Fact]
    public void GetLongestWord_emptyText_ReturnsEmptyText()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        string longestWord = textAnalyser.GetLongestWord();
        
        Assert.Equal("", longestWord);
    }

    [Fact]
    public void GetShortestWord_simpleText_ReturnsShortestWord()
    {
        var textAnalyser = new TextAnalyser(simpleText);
        string shortestWord = textAnalyser.GetShortestWord();
        
        Assert.Equal("a", shortestWord);
    }
    
    [Fact]
    public void GetShortestWord_emptyText_ReturnsEmptyText()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        string shortestWord = textAnalyser.GetShortestWord();
        
        Assert.Equal("", shortestWord);
    }

    [Fact]
    public void GetNumberOfRepetitions_repetitiveText_ReturnsCorrectNumberOfRepetitions()
    {
        var textAnalyser = new TextAnalyser(repetitiveText);
        int numberOfRepetitions = textAnalyser.GetNumberOfRepetitions("word");
        
        Assert.Equal(5, numberOfRepetitions);
    }
    
    [Fact]
    public void GetNumberOfRepetitions_textWithTabulationAndOffset_ReturnsCorrectNumberOfRepetitions()
    {
        var textAnalyser = new TextAnalyser(textWithTabulationAndOffset);
        int numberOfRepetitions = textAnalyser.GetNumberOfRepetitions("line");
        
        Assert.Equal(2, numberOfRepetitions);
    }
    
    [Fact]
    public void GetNumberOfRepetitions_emptyText_ReturnsZeroNumberOfRepetitions()
    {
        var textAnalyser = new TextAnalyser(emptyText);
        int numberOfRepetitions = textAnalyser.GetNumberOfRepetitions("word");
        
        Assert.Equal(0, numberOfRepetitions);
    }
    
    
}
