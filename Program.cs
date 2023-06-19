namespace BST;

 class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            // Create the binary tree
            binaryTree.Insert(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(11);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(65);
            binaryTree.Insert(63);
            binaryTree.Insert(67);

            // Search for value 63
            bool found = binaryTree.Search(63);
            Console.WriteLine("Value 63 found: " + found);
        }
    }
}

