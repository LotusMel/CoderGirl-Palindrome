using System;

namespace Palindrome
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a word to check whether or not is a palindrome: ");
            string myWord;
            myWord = Console.ReadLine();
            
            IsPalindrome(myWord);
            Console.ReadLine();
        }

        // TODO: Create a method that recognizes palindromes.
        public static bool IsPalindrome(string myWord)
        {
            char[] wordPlay = myWord.ToCharArray();
            Array.Reverse(wordPlay);
            string myWordBackwards = new string(wordPlay);
            
            if (myWord.Equals( myWordBackwards, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }
        // The name of the method you create should be IsPalindrome
        // The method should take a string as the input.
        // The method should return a bool - true if the input is a palindrome and false if it is not.
    }
}
