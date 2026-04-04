using System;

class StudentNode{
    public int RollNo;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int rollNo, string name, int age, char grade){
        RollNo = rollNo;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList{
    private StudentNode head;

    public void AddAtBeginning(int rollNo, string name, int age, char grade){
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    public void AddAtEnd(int rollNo, string name, int age, char grade){
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    public void AddAtPosition(int position, int rollNo, string name, int age, char grade){
        if (position <= 1){
            AddAtBeginning(rollNo, name, age, grade);
            return;
        }

        StudentNode temp = head;
        int count = 1;

        while (temp != null && count < position - 1){
            temp = temp.Next;
            count++;
        }

        if (temp == null){
            Console.WriteLine("Invalid position.");
            return;
        }

        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void DeleteByRollNo(int rollNo){
        if (head == null){
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.RollNo == rollNo){
            head = head.Next;
            Console.WriteLine("Student record deleted.");
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNo != rollNo)
        {
            temp = temp.Next;
        }

        if (temp.Next == null){
            Console.WriteLine("Student not found.");
            return;
        }

        temp.Next = temp.Next.Next;
        Console.WriteLine("Student record deleted.");
    }

    public void SearchByRollNo(int rollNo){
        StudentNode temp = head;

        while (temp != null){
            if (temp.RollNo == rollNo){
                DisplayStudent(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    public void UpdateGrade(int rollNo, char newGrade){
        StudentNode temp = head;

        while (temp != null){
            if (temp.RollNo == rollNo){
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    public void DisplayAll(){
        if (head == null){
            Console.WriteLine("No student records available.");
            return;
        }

        StudentNode temp = head;
        while (temp != null){
            DisplayStudent(temp);
            temp = temp.Next;
        }
    }

    private void DisplayStudent(StudentNode student){
        Console.WriteLine("--------------------------");
        Console.WriteLine("Roll No : " + student.RollNo);
        Console.WriteLine("Name    : " + student.Name);
        Console.WriteLine("Age     : " + student.Age);
        Console.WriteLine("Grade   : " + student.Grade);
    }
}

class StudentRecordManagement{
    static void Main(string[] args){
        StudentLinkedList list = new StudentLinkedList();
        int choice;

        do{
            Console.WriteLine("\n--- Student Record Management ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Delete by Roll Number");
            Console.WriteLine("5. Search by Roll Number");
            Console.WriteLine("6. Update Grade");
            Console.WriteLine("7. Display All");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    AddStudent(list, 1);
                    break;
                case 2:
                    AddStudent(list, 2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddStudent(list, 3, pos);
                    break;
                case 4:
                    Console.Write("Enter Roll No: ");
                    list.DeleteByRollNo(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    Console.Write("Enter Roll No: ");
                    list.SearchByRollNo(int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    Console.Write("Enter Roll No: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.Write("Enter new Grade: ");
                    char g = char.Parse(Console.ReadLine());
                    list.UpdateGrade(r, g);
                    break;
                case 7:
                    list.DisplayAll();
                    break;
            }

        } while (choice != 0);
    }

    static void AddStudent(StudentLinkedList list, int mode, int position = 0){
        Console.Write("Enter Roll No: ");
        int roll = int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade = char.Parse(Console.ReadLine());

        if (mode == 1)
            list.AddAtBeginning(roll, name, age, grade);
        else if (mode == 2)
            list.AddAtEnd(roll, name, age, grade);
        else
            list.AddAtPosition(position, roll, name, age, grade);
    }
}

