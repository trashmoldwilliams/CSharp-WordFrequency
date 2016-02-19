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
  }
}
