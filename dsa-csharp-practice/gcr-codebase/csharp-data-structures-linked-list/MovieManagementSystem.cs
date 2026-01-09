using System;

class MovieNode{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;

    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(string title, string director, int year, double rating){
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}

class MovieDoublyLinkedList{
    private MovieNode head;
    private MovieNode tail;

    public void AddAtBeginning(string title, string director, int year, double rating){
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (head == null){
            head = tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }

    
    public void AddAtEnd(string title, string director, int year, double rating){
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (tail == null){
            head = tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    public void AddAtPosition(int position, string title, string director, int year, double rating){
        if (position <= 1){
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode temp = head;
        int count = 1;

        while (temp != null && count < position - 1){
            temp = temp.Next;
            count++;
        }

        if (temp == null || temp.Next == null){
            AddAtEnd(title, director, year, rating);
            return;
        }

        MovieNode newNode = new MovieNode(title, director, year, rating);

        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
    }

    public void RemoveByTitle(string title){
        MovieNode temp = head;

        while (temp != null){
            if (temp.Title.Equals(title)){
                if (temp == head){
                    head = head.Next;
                    if (head != null) head.Prev = null;
                    else tail = null;
                }
                else if (temp == tail){
                    tail = tail.Prev;
                    tail.Next = null;
                }
                else{
                    temp.Prev.Next = temp.Next;
                    temp.Next.Prev = temp.Prev;
                }

                Console.WriteLine("Movie record removed.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found.");
    }

    public void SearchByDirector(string director){
        MovieNode temp = head;
        bool found = false;

        while (temp != null){
            if (temp.Director.Equals(director)){
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found for this director.");
    }

    
    public void SearchByRating(double rating){
        MovieNode temp = head;
        bool found = false;

        while (temp != null){
            if (temp.Rating == rating){
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found with this rating.");
    }

    
    public void UpdateRating(string title, double newRating){
        MovieNode temp = head;

        while (temp != null){
            if (temp.Title.Equals(title)){
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found.");
    }

    public void DisplayForward(){
        if (head == null){
            Console.WriteLine("No movie records.");
            return;
        }

        MovieNode temp = head;
        while (temp != null){
            DisplayMovie(temp);
            temp = temp.Next;
        }
    }

   
    public void DisplayReverse(){
        if (tail == null){
            Console.WriteLine("No movie records.");
            return;
        }

        MovieNode temp = tail;
        while (temp != null){
            DisplayMovie(temp);
            temp = temp.Prev;
        }
    }

    private void DisplayMovie(MovieNode m){
        Console.WriteLine("-------------------------");
        Console.WriteLine("Title    : " + m.Title);
        Console.WriteLine("Director : " + m.Director);
        Console.WriteLine("Year     : " + m.Year);
        Console.WriteLine("Rating   : " + m.Rating);
    }
}

class MovieManagementSystem{
    static void Main(string[] args){
        MovieDoublyLinkedList list = new MovieDoublyLinkedList();
        int choice;

        do{
            Console.WriteLine("\n--- Movie Management System ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Title");
            Console.WriteLine("5. Search by Director");
            Console.WriteLine("6. Search by Rating");
            Console.WriteLine("7. Update Rating");
            Console.WriteLine("8. Display Forward");
            Console.WriteLine("9. Display Reverse");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    AddMovie(list, 1);
                    break;
                case 2:
                    AddMovie(list, 2);
                    break;
                case 3:
                    Console.Write("Enter position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddMovie(list, 3, pos);
                    break;
                case 4:
                    Console.Write("Enter Movie Title: ");
                    list.RemoveByTitle(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Enter Director: ");
                    list.SearchByDirector(Console.ReadLine());
                    break;
                case 6:
                    Console.Write("Enter Rating: ");
                    list.SearchByRating(double.Parse(Console.ReadLine()));
                    break;
                case 7:
                    Console.Write("Enter Movie Title: ");
                    string t = Console.ReadLine();
                    Console.Write("Enter New Rating: ");
                    double r = double.Parse(Console.ReadLine());
                    list.UpdateRating(t, r);
                    break;
                case 8:
                    list.DisplayForward();
                    break;
                case 9:
                    list.DisplayReverse();
                    break;
            }

        } while (choice != 0);
    }

    static void AddMovie(MovieDoublyLinkedList list, int mode, int position = 0){
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Rating: ");
        double rating = double.Parse(Console.ReadLine());

        if (mode == 1)
            list.AddAtBeginning(title, director, year, rating);
        else if (mode == 2)
            list.AddAtEnd(title, director, year, rating);
        else
            list.AddAtPosition(position, title, director, year, rating);
    }
}

