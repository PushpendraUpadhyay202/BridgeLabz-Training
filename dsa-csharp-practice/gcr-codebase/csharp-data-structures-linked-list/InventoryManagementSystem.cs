using System;

class ItemNode{
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int id, string name, int qty, double price){
        ItemId = id;
        ItemName = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

class InventoryList{
    private ItemNode head;

    public void AddAtBeginning(int id, string name, int qty, double price){
        ItemNode newNode = new ItemNode(id, name, qty, price);
        newNode.Next = head;
        head = newNode;
    }

    public void AddAtEnd(int id, string name, int qty, double price){
        ItemNode newNode = new ItemNode(id, name, qty, price);

        if (head == null){
            head = newNode;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    public void AddAtPosition(int position, int id, string name, int qty, double price){
        if (position <= 1 || head == null){
            AddAtBeginning(id, name, qty, price);
            return;
        }

        ItemNode temp = head;
        int count = 1;

        while (temp.Next != null && count < position - 1){
            temp = temp.Next;
            count++;
        }

        ItemNode newNode = new ItemNode(id, name, qty, price);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    
    public void RemoveByItemId(int id){
        if (head == null){
            Console.WriteLine("Inventory is empty.");
            return;
        }

        if (head.ItemId == id){
            head = head.Next;
            Console.WriteLine("Item removed.");
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != id)
            temp = temp.Next;

        if (temp.Next == null){
            Console.WriteLine("Item not found.");
            return;
        }

        temp.Next = temp.Next.Next;
        Console.WriteLine("Item removed.");
    }

    
    public void UpdateQuantity(int id, int newQty){
        ItemNode temp = head;

        while (temp != null){
            if (temp.ItemId == id){
                temp.Quantity = newQty;
                Console.WriteLine("Quantity updated.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Item not found.");
    }

    
    public void SearchById(int id){
        ItemNode temp = head;

        while (temp != null){
            if (temp.ItemId == id){
                DisplayItem(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Item not found.");
    }

    
    public void SearchByName(string name){
        ItemNode temp = head;
        bool found = false;

        while (temp != null){
            if (temp.ItemName.Equals(name)){
                DisplayItem(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Item not found.");
    }

    
    public void DisplayTotalValue(){
        double total = 0;
        ItemNode temp = head;

        while (temp != null){
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }

        Console.WriteLine("Total Inventory Value: " + total);
    }

   
    public void SortByName(bool ascending){
        if (head == null) return;

        for (ItemNode i = head; i.Next != null; i = i.Next){
            for (ItemNode j = i.Next; j != null; j = j.Next){
                int cmp = string.Compare(i.ItemName, j.ItemName);
                if ((ascending && cmp > 0) || (!ascending && cmp < 0))
                    SwapData(i, j);
            }
        }
    }

    
    public void SortByPrice(bool ascending){
        if (head == null) return;

        for (ItemNode i = head; i.Next != null; i = i.Next){
            for (ItemNode j = i.Next; j != null; j = j.Next){
                if ((ascending && i.Price > j.Price) ||
                    (!ascending && i.Price < j.Price))
                    SwapData(i, j);
            }
        }
    }

    private void SwapData(ItemNode a, ItemNode b){
        int id = a.ItemId;
        string name = a.ItemName;
        int qty = a.Quantity;
        double price = a.Price;

        a.ItemId = b.ItemId;
        a.ItemName = b.ItemName;
        a.Quantity = b.Quantity;
        a.Price = b.Price;

        b.ItemId = id;
        b.ItemName = name;
        b.Quantity = qty;
        b.Price = price;
    }

    
    public void DisplayAll(){
        if (head == null){
            Console.WriteLine("Inventory empty.");
            return;
        }

        ItemNode temp = head;
        while (temp != null){
            DisplayItem(temp);
            temp = temp.Next;
        }
    }

    private void DisplayItem(ItemNode item){
        Console.WriteLine("---------------------------");
        Console.WriteLine("Item ID   : " + item.ItemId);
        Console.WriteLine("Name      : " + item.ItemName);
        Console.WriteLine("Quantity  : " + item.Quantity);
        Console.WriteLine("Price     : " + item.Price);
    }
}

class InventoryManagementSystem{
    static void Main(string[] args){
        InventoryList list = new InventoryList();
        int choice;

        do{
            Console.WriteLine("\n--- Inventory Management ---");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Remove by Item ID");
            Console.WriteLine("5. Update Quantity");
            Console.WriteLine("6. Search by Item ID");
            Console.WriteLine("7. Search by Item Name");
            Console.WriteLine("8. Display Total Value");
            Console.WriteLine("9. Sort by Name");
            Console.WriteLine("10. Sort by Price");
            Console.WriteLine("11. Display All");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItem(list, 1);
                    break;
                case 2:
                    AddItem(list, 2);
                    break;
                case 3:
                    Console.Write("Position: ");
                    int pos = int.Parse(Console.ReadLine());
                    AddItem(list, 3, pos);
                    break;
                case 4:
                    Console.Write("Item ID: ");
                    list.RemoveByItemId(int.Parse(Console.ReadLine()));
                    break;
                case 5:
                    Console.Write("Item ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("New Quantity: ");
                    list.UpdateQuantity(id, int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    Console.Write("Item ID: ");
                    list.SearchById(int.Parse(Console.ReadLine()));
                    break;
                case 7:
                    Console.Write("Item Name: ");
                    list.SearchByName(Console.ReadLine());
                    break;
                case 8:
                    list.DisplayTotalValue();
                    break;
                case 9:
                    Console.Write("Ascending? (true/false): ");
                    list.SortByName(bool.Parse(Console.ReadLine()));
                    break;
                case 10:
                    Console.Write("Ascending? (true/false): ");
                    list.SortByPrice(bool.Parse(Console.ReadLine()));
                    break;
                case 11:
                    list.DisplayAll();
                    break;
            }

        } while (choice != 0);
    }

    static void AddItem(InventoryList list, int mode, int position = 0){
        Console.Write("Item ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Item Name: ");
        string name = Console.ReadLine();
        Console.Write("Quantity: ");
        int qty = int.Parse(Console.ReadLine());
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        if (mode == 1)
            list.AddAtBeginning(id, name, qty, price);
        else if (mode == 2)
            list.AddAtEnd(id, name, qty, price);
        else
            list.AddAtPosition(position, id, name, qty, price);
    }
}

