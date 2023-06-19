using System;
using System.Collections.Generic;

namespace BST
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            TreeNode<T> newNode = new TreeNode<T>(value);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                InsertNode(Root, newNode);
            }
        }

        private void InsertNode(TreeNode<T> currentNode, TreeNode<T> newNode)
        {
            if (newNode.Value.CompareTo(currentNode.Value) < 0)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                }
                else
                {
                    InsertNode(currentNode.Left, newNode);
                }
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                }
                else
                {
                    InsertNode(currentNode.Right, newNode);
                }
            }
        }

        public int Size()
        {
            return CalculateSize(Root);
        }

        private int CalculateSize(TreeNode<T> currentNode)
        {
            if (currentNode == null)
            {
                return 0;
            }

            return 1 + CalculateSize(currentNode.Left) + CalculateSize(currentNode.Right);
        }

        public bool Search(T value)
        {
            return SearchNode(Root, value);
        }

        private bool SearchNode(TreeNode<T> currentNode, T value)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (currentNode.Value.Equals(value))
            {
                return true;
            }

            if (value.CompareTo(currentNode.Value) < 0)
            {
                return SearchNode(currentNode.Left, value);
            }
            else
            {
                return SearchNode(currentNode.Right, value);
            }
        }
    }

