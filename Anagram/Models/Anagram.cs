
namespace AnagramProgram.Models
{
    public class Anagram
    {
        public string Word1{get;set;}
        public string Word2{get;set;}

        public Anagram(string word1,string word2)
        {
            Word1 = word1;
            Word2 = word2;
        }

    }
}