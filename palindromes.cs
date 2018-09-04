using System;
using System.Linq;

public class Palindrome
{
  public string userInput;
  public char[] forwardArray;
  public bool PalindromeChecker (string userInput)
  {
  char[] forwardArray = userInput.ToCharArray();
  Array.Reverse(forwardArray);
  int i=0;
  while (i < userInput.Length)
  {
    if (userInput[i] != forwardArray[i])
  {
    return false;
  }
    i++;
  }
    return true;
  }
}


  class Program
{
  public static void Main()
  {
    Console.WriteLine("Write a word and see if it's a palindrome.");
    string userInput = Console.ReadLine().ToLower();
    Palindrome wordReverse = new Palindrome();
    Console.WriteLine(wordReverse.PalindromeChecker(userInput));
  }
}
