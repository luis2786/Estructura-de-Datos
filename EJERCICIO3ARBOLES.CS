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

// Clase para eliminar nodos del BST
public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null)
            return root;

        // Navegación hacia el nodo a eliminar
        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);
        else
        {
            // Caso 1 y 2: Un solo hijo o sin hijos
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // Caso 3: Dos hijos
            // Obtener el sucesor inorden
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    // Encontrar el valor mínimo del subárbol derecho
    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
}

// Clase para mostrar el árbol en Inorden
public class BSTTraversal
{
    public void InOrder(Node root)
    {
        if (root == null)
            return;

        InOrder(root.Left);
        Console.Write(root.Data + " ");
        InOrder(root.Right);
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        // Crear árbol binario
        Node root = new Node(50);

        root.Left = new Node(30);
        root.Right = new Node(70);

        root.Left.Left = new Node(20);
        root.Left.Right = new Node(40);

        root.Right.Left = new Node(60);
        root.Right.Right = new Node(80);

        BSTDeletion deletion = new BSTDeletion();
        BSTTraversal traversal = new BSTTraversal();

        // Mostrar árbol original
        Console.WriteLine("ARBOL ORIGINAL:");
        traversal.InOrder(root);

        // Eliminar nodo
        Console.WriteLine("\n\nELIMINANDO EL NODO 30...");
        root = deletion.DeleteNode(root, 30);

        // Mostrar árbol después de eliminar
        Console.WriteLine("\nARBOL DESPUES DE ELIMINAR:");
        traversal.InOrder(root);

        Console.WriteLine("\n");
    }
}
