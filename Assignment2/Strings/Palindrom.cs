namespace Strings;

public static class Palindrom
{
    public static List<string> GetPalindromes(string text)
    {
        List<string> palindromes = new List<string>();
        
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', ':', '?', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string normalizedWord = word.ToLower();
            
            if (IsPalindrome(normalizedWord))
            {
                if (!palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }
        }
        
        palindromes.Sort();

        return palindromes;
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
    
}