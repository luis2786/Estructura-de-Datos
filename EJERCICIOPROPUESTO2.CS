using System;

// Clase Nodo
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

// Clase Arbol Binario de Busqueda
public class BinarySearchTree
{
    public Node Root;

    // Insercion recursiva
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Recorrido Preorden (Raiz, Izquierda, Derecha)
    public void PreOrder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // Recorrido Inorden (Izquierda, Raiz, Derecha)
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Recorrido Posorden (Izquierda, Derecha, Raiz)
    public void PostOrder(Node node)
    {
        if (node == null)
            return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertar las claves del Ejercicio 1
        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int valor in valores)
        {
            bst.Insert(valor);
        }

        // Mostrar los recorridos
        Console.WriteLine("RECORRIDOS DEL ARBOL BST");

        Console.Write("\nPreorden: ");
        bst.PreOrder(bst.Root);

        Console.Write("\nInorden: ");
        bst.InOrder(bst.Root);

        Console.Write("\nPosorden: ");
        bst.PostOrder(bst.Root);

        Console.WriteLine("\n");
    }
}
