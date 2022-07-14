using System;
// using System.Collections.Generic;
using PChecker.Models;

namespace PChecker.Models
{
  public class Program // does this need to be Solution???
  {
    public static void Main()
    {

      Console.WriteLine("Enter a word to learn if it is a palindrome: ");
      string userInputWord = Console.ReadLine(); // Do we need to pass an argument here?

      Palindrome userInput1 = new Palindrome(userInput);
      // Palindrome userInput2 = new Palindrome();

      Console.WriteLine(userInput);
      Console.WriteLine(revArray);

      // Need to call IsPalindrome

    }
  }

}
