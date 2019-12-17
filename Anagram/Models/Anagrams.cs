using System;
using System.Collections.Generic;
namespace AnagramNameSpace
{
    public class Anagram
    {
        private string word;
        private static List<String> instance;
        private List<String> tempList = new List<String>{};
        public Anagram(string input_word)
        {
            this.word = input_word;
            instance = new List<String>{"vile", "enraged","tap","elegant man","twelve plus one","obecalp"};
        }

        public string GetWord()
        {
            return this.word;
        }
        public void SetWord(string new_word)
        {
            this.word = new_word;
        }

        public static List<String> GteAllAnagrams()
        {
            return instance;
        }

        public static void ClearAllAnagrams()
        {
            instance.Clear();
        }

        public List<String> GetAnagramWords()
        {
            int count = 0;
            List<String> anagram_words = new List<String>{};
            for(int idx = 0; idx < tempList.Count; idx++ )
            {
                string word_from_list = tempList[idx];

                for(int index = 0; index < word_from_list.Length; index++)
                {
                    for(int indexW = 0; indexW < this.word.Length; indexW++)
                    {
                        if(this.word[indexW]==word_from_list[index])
                        {
                            count++;
                        }
                    }

                }
                if(this.word.Length==count)
                {
                    anagram_words.Add(word_from_list);
                }

            }
            return anagram_words;
        }

        public void  CheckEqualEachWord()
        {
            int count = 0;
            //List<String> tempList = new List<String>{};
             for(int idx = 0; idx < instance.Count; idx++ )
            {
                string word = instance[idx];
                for(int index = 0; index < word.Length; index++)
                {

                    if(word[index]!=' ')
                    {
                        count++;
                    }

                }
                if(count==GetNumberLetters())
                {
                    tempList.Add(word);

                }

            }
        }

        public int  GetNumberLetters()
        {
            int count = 0;
            for(int idx = 0; idx < this.word.Length; idx++)
            {
                if(this.word[idx]!=' ')
                {
                    count++;
                }
            }
            return count;
        }



    }
}