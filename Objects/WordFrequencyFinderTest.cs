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
    public void CountRepeats_CheckAppleInApple_0()
    {
      string testPhrase = "apple";
      string testWord = "apple";
      Assert.Equal(1, RepeatCounter.CountRepeats(testPhrase, testWord));
    }
  }
}
