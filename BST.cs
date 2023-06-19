using System;
using System.Collections.Generic;

namespace BST
{
    public interface INode<T> where T : IComparable<T>
    {
        T Key { get; set; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
    }

    public class MyBinaryNode<T> : INode<T> where T : IComparable<T>
    {
        public T Key { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }

        public MyBinaryNode(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private INode<T> root;

        public INode<T> Root
        {
            get { return root; }
        }

        public void Add(T key)
        {
            root = AddRecursive(root, key);
        }

        private INode<T> AddRecursive(INode<T> currentNode, T key)
        {
            if (currentNode == null)
            {
                return new MyBinaryNode<T>(key);
            }

            if (key.CompareTo(currentNode.Key) < 0)
            {
                currentNode.Left = AddRecursive(currentNode.Left, key);
            }
            else if (key.CompareTo(currentNode.Key) > 0)
            {
                currentNode.Right = AddRecursive(currentNode.Right, key);
            }

            return currentNode;
        }

        public void InOrderTraversal(INode<T> currentNode)
        {
            if (currentNode != null)
            {
                InOrderTraversal(currentNode.Left);
                Console.Write(currentNode.Key + " ");
                InOrderTraversal(currentNode.Right);
            }
        }
    }
}
