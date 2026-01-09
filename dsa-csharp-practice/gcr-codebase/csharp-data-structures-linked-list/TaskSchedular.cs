using System;

class TaskNode{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;

    public TaskNode Next;

    public TaskNode(int id, string name, int priority, string dueDate){
        TaskId = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class CircularTaskList{
    private TaskNode head;
    private TaskNode current;   

    
    public void AddAtBeginning(int id, string name, int priority, string dueDate){
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null){
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        newNode.Next = head;
        temp.Next = newNode;
        head = newNode;
    }

    public void AddAtEnd(int id, string name, int priority, string dueDate){
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null){
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    public void AddAtPosition(int position, int id, string name, int priority, string dueDate){
        if (position <= 1 || head == null){
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }

        TaskNode temp = head;
        int count = 1;

        while (temp.Next != head && count < position - 1){
            temp = temp.Next;
            count++;
        }

        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void RemoveByTaskId(int id){
        if (head == null){
            Console.WriteLine("Task list is empty.");
            return;
        }

        TaskNode temp = head;
        TaskNode prev = null;

        do{
            if (temp.TaskId == id){
                if (temp == head){
                    TaskNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    if (head.Next == head){
                        head = null;
                        current = null;
                        return;
                    }

                    last.Next = head.Next;
                    head = head.Next;
                }
                else{
                    prev.Next = temp.Next;
                }

                if (current == temp)
                    current = temp.Next;

                Console.WriteLine("Task removed.");
                return;
            }

            prev = temp;
            temp = temp.Next;

        } while (temp != head);

        Console.WriteLine("Task not found.");
    }

    
    public void ViewCurrentAndMoveNext(){
        if (current == null){
            Console.WriteLine("No tasks available.");
            return;
        }

        DisplayTask(current);
        current = current.Next;
    }

    
    public void DisplayAll(){
        if (head == null){
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        do{
            DisplayTask(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority){
        if (head == null){
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        bool found = false;

        do{
            if (temp.Priority == priority){
                DisplayTask(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No tasks found with this priority.");
    }

    private void DisplayTask(TaskNode t){
        Console.WriteLine("----------------------------");
        Console.WriteLine("Task ID   : " + t.TaskId);
        Console.WriteLine("Name      : " + t.TaskName);
        Console.WriteLine("Priority  : " + t.Priority);
        Console.WriteLine("Due Date  : " + t.DueDate);
    }
}

class TaskSchedular{
    static void Main(string[] args){
        CircularTaskList scheduler = new CircularTaskList();
        int choice;

        do{
            Console.WriteLine("\n--- Task Scheduler ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Task ID");
            Console.WriteLine("5. View Current Task & Move Next");
            Console.WriteLine("6. Display All Tasks");
            Console.WriteLine("7. Search by Priority");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    AddTask(scheduler, 1);
                    break;
                case 2:
                    AddTask(scheduler, 2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddTask(scheduler, 3, pos);
                    break;
                case 4:
                    Console.Write("Enter Task ID: ");
                    scheduler.RemoveByTaskId(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    scheduler.ViewCurrentAndMoveNext();
                    break;
                case 6:
                    scheduler.DisplayAll();
                    break;
                case 7:
                    Console.Write("Enter Priority: ");
                    scheduler.SearchByPriority(int.Parse(Console.ReadLine()));
                    break;
            }

        } while (choice != 0);
    }

    static void AddTask(CircularTaskList list, int mode, int position = 0){
        Console.Write("Task ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Task Name: ");
        string name = Console.ReadLine();
        Console.Write("Priority: ");
        int priority = int.Parse(Console.ReadLine());
        Console.Write("Due Date: ");
        string dueDate = Console.ReadLine();

        if (mode == 1)
            list.AddAtBeginning(id, name, priority, dueDate);
        else if (mode == 2)
            list.AddAtEnd(id, name, priority, dueDate);
        else
            list.AddAtPosition(position, id, name, priority, dueDate);
    }
}

