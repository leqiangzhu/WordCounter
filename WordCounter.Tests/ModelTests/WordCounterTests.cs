using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
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

      string words = "hello,world";
      String[] array={"hello","world"};
      //string [] words = Regex.Split(word, @"\W+");
      //Act
      String[] result = Regex.Split(words, @"\W+");
      //Assert
      CollectionAssert.AreEqual(array, result);


    }

    [TestMethod]
    public void CountWord_ReturnUserWord_int()
    {
      string words = "hello,world hello";
      string word="hello";
      //Act
      RepeatCounter RC= new RepeatCounter();
      int result= RC.CountWord(words,word);
      //Assert
      Assert.AreEqual(2, result);


    }






    }

  }
