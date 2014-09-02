//Write a program to read the tree and find:
//the root node
//all leaf nodes
//all middle nodes
//the longest path in the tree
//* all paths in the tree with given sum S of their nodes
//* all subtrees with given sum S of their nodes
//
//Input:
//7       
//2 4
//3 2
//5 0
//3 5
//5 6
//5 1
//You can also try with:
//11
//2 4
//3 2
//5 0
//3 5
//5 6
//5 1
//4 7
//4 8
//7 9
//7 10

namespace _01.Tree_Traversals
{
    using System;
    using System.Collections.Generic;

    public class TreeTraversals
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            TreeNode<int>[] nodes = new TreeNode<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new TreeNode<int>(i);
            }

            for (int i = 0; i < n - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var currentNodes = edgeAsString.Split(' ');

                int parentId = int.Parse(currentNodes[0]);
                int childId = int.Parse(currentNodes[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].hasParent = true;
            }

            //01. The Root Node
            var rootIndex = FindRoot(nodes);
            Console.WriteLine("The root of the tree is {0}.", rootIndex.Value);

            //02. All leaf nodes
            var leafs = FindLeafs(nodes);
            Console.Write("The leafs in the tree are: ");
            for (int i = 0; i < leafs.Count; i++)
            {
                Console.Write(i == leafs.Count - 1 ? leafs[i].Value.ToString() : leafs[i].Value + ", ");
            }
            Console.WriteLine(".");

            //03. All middle nodes
            var middleNodes = FindMiddleNodes(nodes);
            Console.Write("The middle nodes in the tree are: ");
            for (int i = 0; i < middleNodes.Count; i++)
            {
                Console.Write(i == middleNodes.Count - 1 ? middleNodes[i].Value.ToString() : middleNodes[i].Value + ", ");
            }
            Console.WriteLine(".");

            //04. Longest path in tree
            int longestPath = 0;
            FindLongestPathFromRoot(FindRoot(nodes), 0, ref longestPath);
            Console.WriteLine("The longest path in the tree has {0} steps.", longestPath);
        }

        private static TreeNode<int> FindRoot(TreeNode<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true; 
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException();
        }

        private static List<TreeNode<int>> FindLeafs(TreeNode<int>[] nodes)
        {
            List<TreeNode<int>> list = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    list.Add(node);
                }
            }

            return list;
        }

        private static List<TreeNode<int>> FindMiddleNodes(TreeNode<int>[] nodes)
        {
            List<TreeNode<int>> list = new List<TreeNode<int>>();

            foreach (var node in nodes)
            {
                if (node.hasParent && node.Children.Count != 0)
                {
                    list.Add(node);
                }
            }

            return list;
        }

        private static void FindLongestPathFromRoot(TreeNode<int> treeNode, int currentPath, ref int maxPath)
        {
            if (currentPath > maxPath)
            {
                maxPath = currentPath;
            }

            foreach (var node in treeNode.Children)
            {
                FindLongestPathFromRoot(node, currentPath + 1, ref maxPath);
            }
        }
    }
}
