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

// Arbol Binario de Busqueda
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

    // Recorrido Inorden
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Guardar recorrido Inorden en una lista
    public void InOrderList(Node node, System.Collections.Generic.List<int> lista)
    {
        if (node == null)
            return;

        InOrderList(node.Left, lista);
        lista.Add(node.Data);
        InOrderList(node.Right, lista);
    }

    // Comprobar si la lista esta ordenada estrictamente
    public bool IsAscending(System.Collections.Generic.List<int> lista)
    {
        for (int i = 0; i < lista.Count - 1; i++)
        {
            if (lista[i] >= lista[i + 1])
                return false;
        }

        return true;
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertar los mismos valores del Ejercicio 1
        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int valor in valores)
        {
            bst.Insert(valor);
        }

        // Mostrar recorrido Inorden
        Console.WriteLine("DEMOSTRACION DEL RECORRIDO INORDEN");

        Console.Write("\nRecorrido Inorden: ");
        bst.InOrder(bst.Root);

        // Guardar los valores en una lista
        System.Collections.Generic.List<int> lista =
            new System.Collections.Generic.List<int>();

        bst.InOrderList(bst.Root, lista);

        // Comprobar orden ascendente
        Console.WriteLine("\n");

        if (bst.IsAscending(lista))
        {
            Console.WriteLine("La secuencia esta ordenada");
            Console.WriteLine("Resultado: ORDEN ASCENDENTE CORRECTO");
        }
        else
        {
            Console.WriteLine("La secuencia no esta ordenada");
        }
    }
}
