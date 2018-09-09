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
    //the method test input
    [TestMethod]
    public void CheckWord_ReturnUserWord_bool()
    {
      //Arrange
      string words = " ";
      string word = "hello";
      RepeatCounter RC= new RepeatCounter(words,word);
      //Act
      bool result = RC.CheckWord(words);
      //Assert
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void CountWord_ReturnUserWord_int()
    {
      string words = "hello,world hello";
      string word="hello";
      //Act
      RepeatCounter RC= new RepeatCounter(words,word);
      int result= RC.CountWord(words,word);
      //Assert
      Assert.AreEqual(2, result);
    }
    }
  }
