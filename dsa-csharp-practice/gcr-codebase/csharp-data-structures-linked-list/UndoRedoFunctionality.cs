using System;

class TextStateNode
{
    public string Content;
    public TextStateNode Prev;
    public TextStateNode Next;

    public TextStateNode(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextStateNode head;
    private TextStateNode tail;
    private TextStateNode current;
    private int count;
    private int maxSize;

    public TextEditor(int size)
    {
        head = null;
        tail = null;
        current = null;
        count = 0;
        maxSize = size;
    }

    public void AddState(string content)
    {
        TextStateNode newNode = new TextStateNode(content);

        if (head == null)
        {
            head = tail = current = newNode;
            count = 1;
            return;
        }

        if (current != tail)
        {
            TextStateNode temp = current.Next;
            while (temp != null)
            {
                TextStateNode next = temp.Next;
                temp.Prev = null;
                temp.Next = null;
                temp = next;
                count--;
            }
            current.Next = null;
            tail = current;
        }

        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
        current = newNode;
        count++;

        if (count > maxSize)
        {
            head = head.Next;
            head.Prev = null;
            count--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
            current = current.Next;
    }

    public void DisplayCurrentState()
    {
        if (current == null)
            Console.WriteLine("No text available");
        else
            Console.WriteLine("Current Text: " + current.Content);
    }
}

class UndoRedoFunctionality
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor(10);

        editor.AddState("H");
        editor.AddState("He");
        editor.AddState("Hel");
        editor.AddState("Hell");
        editor.AddState("Hello");

        editor.DisplayCurrentState();

        editor.Undo();
        editor.DisplayCurrentState();

        editor.Undo();
        editor.DisplayCurrentState();

        editor.Redo();
        editor.DisplayCurrentState();

        editor.AddState("Hello World");
        editor.DisplayCurrentState();
    }
}

