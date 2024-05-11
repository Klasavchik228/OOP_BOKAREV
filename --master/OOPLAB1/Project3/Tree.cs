using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3

    {

        internal class TreeNode
        {
            public int Value { get; }
            public List<TreeNode> Children { get; }

            public TreeNode(int value)
            {
                Value = value;
                Children = new List<TreeNode>();
            }

            public void AddChild(TreeNode child)
            {
                Children.Add(child);
            }

            public void PrintChildrenValues()
            {
                Console.Write($"Children of node {Value}: ");
                foreach (var child in Children)
                {
                    Console.Write($"{child.Value} ");
                }
                Console.WriteLine();

                foreach (var child in Children)
                {
                    child.PrintChildrenValues();
                }
            }
        }

    }


