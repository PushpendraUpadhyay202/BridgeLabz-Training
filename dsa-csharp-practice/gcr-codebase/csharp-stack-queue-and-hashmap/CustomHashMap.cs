using System;

class HashMap
{
    private class Node
    {
        public int Key;
        public int Value;
        public Node Next;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private Node[] buckets;
    private int size;

    public HashMap(int capacity)
    {
        size = capacity;
        buckets = new Node[size];
    }

    private int GetBucketIndex(int key)
    {
        return Math.Abs(key) % size;
    }

    
    public void Put(int key, int value)
    {
        int index = GetBucketIndex(key);
        Node head = buckets[index];

        Node current = head;
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value;
                return;
            }
            current = current.Next;
        }

        Node newNode = new Node(key, value);
        newNode.Next = head;
        buckets[index] = newNode;
    }

    
    public int Get(int key)
    {
        int index = GetBucketIndex(key);
        Node current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;

            current = current.Next;
        }

        throw new Exception("Key not found");
    }

    
    public void Remove(int key)
    {
        int index = GetBucketIndex(key);
        Node current = buckets[index];
        Node prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                    buckets[index] = current.Next;
                else
                    prev.Next = current.Next;

                return;
            }
            prev = current;
            current = current.Next;
        }

        throw new Exception("Key not found");
    }
}

class Program
{
    static void Main()
    {
        HashMap map = new HashMap(5);

        map.Put(1, 100);
        map.Put(6, 600);   
        map.Put(11, 1100); 

        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Get(6));
        Console.WriteLine(map.Get(11));

        map.Remove(6);

        try
        {
            Console.WriteLine(map.Get(6));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

