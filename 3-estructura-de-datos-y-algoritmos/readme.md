# Ruta de Aprendizaje para Estructura de Datos y Algoritmia

## Paso 0: Introducción a las Estructuras de Datos y Algoritmos

- **Conceptos Básicos**: Entender qué son las estructuras de datos y los algoritmos, y por qué son importantes.
- **Big O Notation**: Aprender la notación Big O para analizar la eficiencia de algoritmos.
- **Complejidad Temporal y Espacial**: Diferenciar entre complejidad temporal y espacial y cómo afectan el rendimiento.
- **Recursos Adicionales**: Recomiendo la lectura del siguiente libro: [Grokking Algorithms](https://edu.anarcho-copy.org/Algorithm/grokking-algorithms-illustrated-programmers-curious.pdf) para una introducción visual y amigable a estos conceptos.

## Paso 1: Estructuras de Datos Básicas

1. **Arreglos y Listas**: Comprender cómo funcionan los arreglos y las listas, sus operaciones básicas y complejidades.
2. **Pilas (Stacks)**: Aprender el funcionamiento de una pila, sus operaciones y usos comunes.
3. **Colas (Queues)**: Entender las colas, sus operaciones y aplicaciones prácticas.

### Tarea de Práctica:

- Implementa una lista enlazada simple y realiza operaciones de inserción, eliminación y búsqueda.
- Implementa una pila usando un arreglo o una lista enlazada y realiza operaciones básicas.
- Implementa una cola y realiza operaciones de encolado y desencolado.

### Ejemplo:

```csharp
public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public bool Search(int data)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.Data == data)
                return true;
            temp = temp.Next;
        }
        return false;
    }

    public void Delete(int data)
    {
        if (head == null) return;

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node temp = head;
        while (temp.Next != null && temp.Next.Data != data)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }
}
```

## Paso 2: Estructuras de Datos Intermedias

1. **Listas Enlazadas Dobles**: Comprender cómo funcionan y cuándo usarlas.
2. **Hash Tables**: Aprender sobre tablas hash, funciones hash y manejo de colisiones.
3. **Árboles**: Introducción a árboles, árboles binarios y sus operaciones básicas.
4. **Grafos**: Conceptos básicos de grafos, representación y operaciones comunes.

### Tarea de Práctica:

- Implementa una lista doblemente enlazada y realiza operaciones básicas.
- Crea una tabla hash simple con manejo de colisiones mediante encadenamiento.
- Implementa un árbol binario y realiza operaciones de inserción, eliminación y recorrido.
- Representa un grafo usando listas de adyacencia y matrices de adyacencia.

### Ejemplo:

```csharp
public class DoubleNode
{
    public int Data;
    public DoubleNode Next;
    public DoubleNode Prev;

    public DoubleNode(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}

public class DoublyLinkedList
{
    private DoubleNode head;

    public void Insert(int data)
    {
        DoubleNode newNode = new DoubleNode(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            DoubleNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Prev = temp;
        }
    }

    public bool Search(int data)
    {
        DoubleNode temp = head;
        while (temp != null)
        {
            if (temp.Data == data)
                return true;
            temp = temp.Next;
        }
        return false;
    }

    public void Delete(int data)
    {
        if (head == null) return;

        if (head.Data == data)
        {
            head = head.Next;
            if (head != null)
                head.Prev = null;
            return;
        }

        DoubleNode temp = head;
        while (temp.Next != null && temp.Next.Data != data)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
            if (temp.Next != null)
                temp.Next.Prev = temp;
        }
    }
}
```

## Paso 3: Algoritmos de Ordenamiento y Búsqueda

1. **Ordenamiento**: Aprender algoritmos de ordenamiento como burbuja, inserción, selección, merge sort y quick sort.
2. **Búsqueda**: Implementar y comprender algoritmos de búsqueda como búsqueda lineal y búsqueda binaria.

### Tarea de Práctica:

- Implementa el algoritmo de ordenamiento burbuja y analiza su complejidad.
- Implementa y compara el algoritmo de ordenamiento quick sort con merge sort.
- Implementa una búsqueda binaria en un arreglo ordenado y analiza su complejidad.

### Ejemplo:

```csharp
public class Sorting
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static int BinarySearch(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;
        while (l <= r)
        {
            int m = l + (r - l) / 2;

            // Check if x is present at mid
            if (arr[m] == x)
                return m;

            // If x greater, ignore left half
            if (arr[m] < x)
                l = m + 1;

            // If x is smaller, ignore right half
            else
                r = m - 1;
        }

        // if we reach here, then element was not present
        return -1;
    }
}
```

## Paso 4: Practicar mucho con leetcode y hackerRank

hard: https://leetcode.com/problems/merge-k-sorted-lists/description/
