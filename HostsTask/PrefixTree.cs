using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HostsTask
{
    public class PrefixTree
    {
        private class TreeNode
        {
            public string Word { get; set; }
            public Dictionary<string, TreeNode> Children { get;set; }
            public bool isEnd;
        }

        private readonly TreeNode root;

        public PrefixTree(string[] sequences)
        {
            root = new TreeNode();
            foreach (var sequence in sequences)
            {
                AddSequence(sequence);
            }
        }

        private void AddSequence(string sequence)
        {
            var current = root;
            string[] words = sequence.Split('.');

            for (int i = words.Length - 1; i >=0; i-- )
            {
                if (current.Children != null && current.Children.TryGetValue(words[i], out var node))
                {
                    current = node;
                }
                else
                {
                    if (current.Children == null)
                        current.Children = new Dictionary<string, TreeNode>();

                    var children = new TreeNode() { Word = words[i] }; 

                    current.Children.Add(words[i], children);
                    current = children;
                }
            }

            current.isEnd = true;
        }

        public bool Contain(string sequence)
        {
            var current = root;
            string[] words = sequence.Split('.');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (current.Children.TryGetValue(words[i], out var node))
                {
                    current = node;
                    if (current.isEnd == true)
                        return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
