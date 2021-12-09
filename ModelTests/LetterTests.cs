using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {

    [TestMethod]
    public void IsScore_ResturnLetter_True()
    {
      Score testScore = new Score("A");
      Assert.AreEqual( typeof(Score), testScore.GetType());
    }
  }
}