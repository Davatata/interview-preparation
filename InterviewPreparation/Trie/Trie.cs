using System.Collections.Generic;

namespace DataStructures.Trie
{
    public class Trie
    {

        Node Root;

        class Node
        {
            public Dictionary<char, Node> Children;
            public bool IsCompleteWord;

            public Node()
            {
                Children = new Dictionary<char, Node>();
                IsCompleteWord = false;
            }
        }

        public Trie()
        {
            Root = new Node();
        }

        // Adds words to the trie if they don't already exist.
        public void Insert(string word)
        {
            var node = Root;
            foreach (var letter in word)
            {
                if (!node.Children.ContainsKey(letter))
                {
                    var newNode = new Node();
                    node.Children.Add(letter, newNode);
                    node = newNode;
                }
                else
                {
                    node = node.Children[letter];
                }
            }

            node.IsCompleteWord = true;
        }

        // Determine if the passed in string (word) exists in the trie as
        // a complete word.
        // True if the last letter in the word is a complete word,
        // False otherwise.
        public bool Search(string word)
        {
            var node = Root;
            foreach (var letter in word)
            {
                if (!node.Children.ContainsKey(letter))
                {
                    return false;
                }
                node = node.Children[letter];
            }

            return node.IsCompleteWord;
        }

        // If there exists a word that starts with the prefix string
        // return true, otherwise false.
        public bool StartsWith(string prefix)
        {
            var node = Root;
            foreach (var letter in prefix)
            {
                if (!node.Children.ContainsKey(letter))
                {
                    return false;
                }
                node = node.Children[letter];
            }

            return true;
        }

        // If substring of word is also a word, return substring.
        // Otherwise return the original word.
        public string FirstHit(string word)
        {
            var node = Root;
            var result = "";
            foreach (var letter in word)
            {
                if (!node.Children.ContainsKey(letter))
                {
                    return word;
                }

                node = node.Children[letter];

                result += letter;

                if (node.IsCompleteWord)
                {
                    return result;
                }
            }

            return word;
        }
    }
}
