using System;
using System.Collections.Generic;
namespace WordFrequencyFinder
{
  public class RepeatCounter
  {

    public static int CountRepeats(string inputPhrase, string inputWord)
    {
      int repeatCount = 0;
      string[] phraseArray = inputPhrase.Split(' ');

      for(var i = 0; i < phraseArray.Length; i++)
      {
        string checkWord = "";

        foreach (char letter in phraseArray[i])
        {
          if(!char.IsPunctuation(letter))
          {
            checkWord += letter;
          }
        }

        if (checkWord.ToLower() == inputWord.ToLower())
        {
          repeatCount += 1;
        }
      }

      return repeatCount;
    }
  }
}
