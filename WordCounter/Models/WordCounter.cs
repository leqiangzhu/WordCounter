using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public int CountWord(string  words,string  word)
    {
      //Console.WriteLine("please input words");
    //  words=Console.ReadLine();
    //  Console.WriteLine("please input word you want to count");
    //  word=Console.ReadLine();
      //use Regex.Split method,put the string into a string array
      String[] wordsArray=Regex.Split(words, @"\W+");
      int count =0;
      //use for loop ,look for the matching word
      for(int i=0; i<wordsArray.Length; i++)
      {
        if (word==wordsArray[i])
        {
          //count the number
          count++;
        }

      }

      return count;

    }


  }

  public class Program
  {
    public static void Main()
    {
      RepeatCounter RC= new RepeatCounter();

    //  int number=RC.CountWord();
    //  Console.WriteLine("out is :"+number);

    }
  }
}
