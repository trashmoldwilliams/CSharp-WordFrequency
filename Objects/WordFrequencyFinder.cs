using System;
using System.Collections.Generic;
namespace WordFrequencyFinder
{
  public class RepeatCounter
  {

    public static int CountRepeats(string phrase, string word)
    {
      int repeatCount = 0;

      if (phrase == word)
      {
        repeatCount += 1;
      }

      return repeatCount;
    }
  }
}
