using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static bool IsPalindrome(string word)
        {
            return String.Equals(word, new string(word.Reverse().ToArray()));
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(IsPalindrome(s)); 
        }
    }
}
