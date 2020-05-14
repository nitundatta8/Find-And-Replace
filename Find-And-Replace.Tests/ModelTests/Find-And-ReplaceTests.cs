using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceTest
  {
    [TestMethod]

    public void FindAndReplace_ReturnString_ReplaceWord()
    {
      string sentence = "The man said hi";
      string word = "hi";
      string replaceWord = "hello";
      string result = ReplaceWord.FindAndReplace(sentence, word, replaceWord);
      Assert.AreEqual("The man said hello", result);
    }

  }
}