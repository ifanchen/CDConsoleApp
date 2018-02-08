namespace CDUtility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// String Utility Class contains 2 functions
    /// 1. Reverse the order of works in a input sentence
    /// 2. Get string contains only the characters found in both input strings.
    /// </summary>
    public static class StringUtility
    {
        /// <summary>
        /// Reverse the order of words in a input sentence.
        /// Extra space between words will be moved from output.
        /// </summary>
        /// <param name="sentence">The input sentence.</param>
        /// <returns>Reverse the order of words from input sentence</returns>
        public static string RevereSentence(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return sentence;
            }
            
            // Add each word into an array and reverse it.
            var words = sentence.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Reverse();
            return string.Join(" ", words);
        }

        /// <summary>
        /// Get string contains only the characters found in both input strings.
        /// </summary>
        /// <param name="s1">The first input string</param>
        /// <param name="s2">The second input string</param>
        /// <returns>characters found in both input string</returns>
        public static string GetMatching(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return string.Empty;
            }

            // Get distinct char for each input
            var distS1 = s1.Distinct().ToArray();
            var distS2 = s2.Distinct().ToArray();
            char[] smallInput,b;
            
            // Get the smaller input
            if (distS1.Count() <= distS2.Count())
            {
                smallInput = distS1;
                b = distS2;
            }
            else
            {
                smallInput = distS2;
                b = distS1;
            }

            StringBuilder result = new StringBuilder();
            // Use smaller input for looping
            for (int i=0; i< smallInput.Length; i++)
            {
                if (b.Contains(smallInput[i]))
                {
                    result.Append(smallInput[i]);
                }
            }

            return result.ToString();
        }
    }
}
