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

/*

string [] strArray = sentence.Split("");
string [] wrdArray = word.Split("");
string [] rplArray = replace

for (int i = 0; i < strArray.Length; i++)
{
  if(strArray[i] == wrdArray[0])
  {
    int startIndex = i;
    int endIndex = 0;
    bool match = true;
    for (int j = 0; j < wrdArray.Length; i++)
    {
      if(!(strArray[i+j] == wrdArray[j]))
      {
        bool match = false;
      }
      endIndex = startIndex + wrdArray.Length;
    }
    if (match)
    {
      replace 
    }

  }
}

*/
