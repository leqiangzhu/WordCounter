using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {

    private  string _sentence;
    private  string _word;

    public RepeatCounter(string sentence,string word)
    {
      _sentence = sentence;
      _word = word;
    }

    public void SetWords(string sentence)
    {
      _sentence=sentence;
    }

    public string GetWords()
    {
      return _sentence;
    }


    public void SetWord(string word)
    {
      _word=word;
    }

    public string GetWord()
    {
      return _word;
    }

    //the method to Check the input if viod
    public bool CheckWord(string word)
    {
      if (word==" "|| word =="" || word==null)
      {
        return false;
        //Console.WriteLine("please input sentence");
      }
      return true;
    }

    public int CountWord(string  sentence,string  word)
    {
      //use Regex.Split method,put the string into a string array
      String[] sentenceArray=Regex.Split(sentence, @"\W+");
      //declear the int  var=0;
      int count =0;
      //use for loop ,compare the word(which the uesr wants to match ),look for the matching word
      //count how many times, and return it
      for(int i=0; i<sentenceArray.Length; i++)
      {
        if (word.ToLower()==sentenceArray[i].ToLower())
        {
          //count the number
          count++;
        }
      }
      return count;
    }


    // public void StarProgram()
    // {
    //
    // }
  }

  public class Program
  {
    public static void Main()
    {
      bool sentenceFlag=true;
      bool wordFlag=true;
      Console.WriteLine("please input a sentence");
      string sentence = Console.ReadLine();
      Console.WriteLine("please input a word");
      string word = Console.ReadLine();
      RepeatCounter rc=new RepeatCounter(sentence,word);
      sentenceFlag =rc.CheckWord(sentence);
      wordFlag =rc.CheckWord(word);

      if(sentenceFlag==false|| wordFlag==false)
      {
        Console.WriteLine("the input is viod,please input again");
        Main();
      }else{
        int number=rc.CountWord(sentence ,word);
        Console.WriteLine(word +"  appears  "+ number + " times.");
      }

    }
  }
}
