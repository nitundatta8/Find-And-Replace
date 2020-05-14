using System;
using FindAndReplace.Models;

namespace FindAndReplace
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("Enter a sentence: ");
      string sent = Console.ReadLine();
      Console.Write("Enter the word you want replaced: ");
      string word = Console.ReadLine();
      Console.Write("Enter the word you want to replace it with: ");
      string replaceWord = Console.ReadLine();

      Console.WriteLine(ReplaceWord.FindAndReplace(sent, word, replaceWord));

    }
  }
}