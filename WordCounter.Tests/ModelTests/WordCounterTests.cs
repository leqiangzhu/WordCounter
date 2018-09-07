using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetWord_ReturnUserWord_String()
    {

      string word = "hello world";
      //string [] words = Regex.Split(word, @"\W+");
      //Act
      string[] result = Regex.Split(word, @"\W+");
      //Assert
      CollectionAssert.AreEqual({"hello","world"}, result);


    }

    }

  }
