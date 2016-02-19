using System;
using System.Collections.Generic;
namespace WordFrequencyFinder
{
  public class RepeatCounter
  {

    public static int CountRepeats(string phrase, string word)
    {
      int repeatCount = 0;
      string[] phraseArray = phrase.Split(' ');

      for (var i = 0; i < phraseArray.Length; i++)
      {
        if (phraseArray[i].ToLower() == word.ToLower())
        {
          repeatCount += 1;
        }
      }

      return repeatCount;
    }
  }
}
