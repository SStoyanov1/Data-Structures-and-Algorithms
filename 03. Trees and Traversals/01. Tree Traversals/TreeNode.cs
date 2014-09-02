using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tree_Traversals
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        public List<TreeNode<T>> Children { get; set; }

        public bool hasParent { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }
    }
}
