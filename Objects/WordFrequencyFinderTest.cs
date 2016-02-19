using Xunit;
using WordFrequencyFinder;
using System;
using System.Collections.Generic;


namespace WordFrequencyFinderTest
{
  public class WordFrequencyFinderTester
  {
    [Fact]
    public void CountRepeats_CheckOrangeInApple_0()
    {
      string testPhrase = "apple";
      string testWord = "orange";
      Assert.Equal(0, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_CheckAppleInApple_1()
    {
      string testPhrase = "apple";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_CheckAppleInAppleApple_2()
    {
      string testPhrase = "apple apple";
      string testWord = "apple";
      Assert.Equal(2, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_CheckAppleInAppleOrangeApple_2()
    {
      string testPhrase = "apple orange apple";
      string testWord = "apple";
      Assert.Equal(2, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_CheckAlternatingCases_1()
    {
      string testPhrase = "ApPlE";
      string testWord = "aPpLe";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnorePeriods_1()
    {
      string testPhrase = "This is an apple.";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreCommas_1()
    {
      string testPhrase = "apple, this is";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreDoubleQuotes_1()
    {
      string testPhrase = "This is an \"apple\"";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreSingleQuotes_1()
    {
      string testPhrase = "This is an 'apple'";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreSemicolons_1()
    {
      string testPhrase = "I want an apple; however, they are rare.";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreParenthesis_1()
    {
      string testPhrase = "Examples of fruit (apple , orange , pear)";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreCurlyBrackets_1()
    {
      string testPhrase = "Examples of fruit {apple , orange , pear}";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreSquareBrackets_1()
    {
      string testPhrase = "Examples of fruit [apple , orange , pear]";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreQuestionMarks_1()
    {
      string testPhrase = "Can I have that apple?";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreExclamationPoints_1()
    {
      string testPhrase = "Give me that apple!";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_IgnoreColons_1()
    {
      string testPhrase = "apple: five dollars";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }

    [Fact]
    public void CountRepeats_TestLargeArticleAccuracy_3()
    {
      string testPhrase = "Apples were brought to North America by colonists in the 17th century, and the first apple orchard on the North American continent was planted in Boston by Reverend William Blaxton in 1625. The only apples native to North America are crab apples, which were once called \"common apples\". Apple varieties brought as seed from Europe were spread along Native American trade routes, as well as being cultivated on Colonial farms. An 1845 United States apples nursery catalogue sold 350 of the \"best\" varieties, showing the proliferation of new North American varieties by the early 19th century.";
      string testWord = "apples";
      Assert.Equal(5, RepeatCounter.CountRepeats(testPhrase, testWord));
    }
  }
}
