using System.Text;
using System.Text.RegularExpressions;

namespace Strings;

public static class ReverseWordsInSen
{
    public static string ReverseWordsInSentence(string sentence)
    {

        {
            string pattern = @"([.,:;=()&[\]""'\\/!? ])";
            
            string[] words = Regex.Split(sentence, pattern);
            
            List<string> wordList = new List<string>();
            List<string> separatorList = new List<string>();

            foreach (string part in words)
            {
                if (Regex.IsMatch(part, pattern))
                    separatorList.Add(part);
                else if (!string.IsNullOrEmpty(part))
                    wordList.Add(part);
            }
            
            wordList.Reverse();
            
            StringBuilder result = new StringBuilder();
            int wordIndex = 0, separatorIndex = 0;
            foreach (string part in words)
            {
                if (Regex.IsMatch(part, pattern))
                {
                    result.Append(separatorList[separatorIndex]);
                    separatorIndex++;
                }
                else if (!string.IsNullOrEmpty(part))
                {
                    result.Append(wordList[wordIndex]);
                    wordIndex++;
                }
            }

            return result.ToString();
        }
    }
    
}