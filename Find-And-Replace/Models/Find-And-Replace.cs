using System;
using System.Collections.Generic;

namespace FindAndReplace.Models
{
  public class ReplaceWord
  {


    public static string FindAndReplace(string sentence, string word, string replaceWord)
    {
      string[] strArray = sentence.Split(" ");
      for (int i = 0; i < strArray.Length; i++)
      {
        if (strArray[i].Contains(word))
        {
          strArray[i] = replaceWord;
        }
      }
      string result = String.Join(" ", strArray);
      return result;
    }
  }


}