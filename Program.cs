namespace BST;

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree<int> bst = new BinarySearchTree<int>();

        bst.Add(56);
        bst.Add(30);
        bst.Add(70);

        Console.WriteLine("In-order traversal of the BST:");
        bst.InOrderTraversal(bst.Root);
        Console.WriteLine();
    }
}

