using System;

public class Node
{
    public int data;
    public Node left;
    public Node right;

    //construtor
    public Node(int value)
    {
        data = value;
        left = null;
        right = null;
    }
}

public class BinaryTree
{

    public Node root;

    //construtor da arvore
    public BinaryTree()
    {
        root = null;
    }

    
    public void Insert(int value)
    {
        Node newNode = new Node(value);

        if(root == null)
        {
            root = newNode;
            return;
        }

        Node aux = root;

        while(true)
        {
            if(value < aux.data)
            {
                if(aux.left == null)
                {
                    aux.left = newNode;
                    break;
                }
            }
            else
            {
                if(aux.right == null)
                {
                    aux.right = newNode;
                    break;
                }
            }
        }
    }


    public void InOrder(Node node)
    {
        if(node != null)
        {
            InOrder(node.left);
            Console.Write(node.data + " ");
            InOrder(node.right);
        }
    }
}

class Program
{
    static void Main(string[]args)
    {
        BinaryTree tree = new BinaryTree();

        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        tree.Insert(1);
        tree.Insert(9);

        Console.WriteLine("Inorder: ");
        tree.InOrder(tree.root);
        Console.WriteLine();
    }
}