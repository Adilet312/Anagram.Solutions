using System;
using System.Collections.Generic;
namespace AnagramNameSpace
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("PLease write word: ");
            string word = Console.ReadLine();
            Anagram words = new Anagram(word);
            List<String> list = words.GetAnagramWords();
            Console.WriteLine(list.ToString());
        }
    }
}