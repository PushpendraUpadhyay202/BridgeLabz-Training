using System;

class Person{
    protected string name;
    protected int id;

    public Person(string name, int id){
        this.name = name;
        this.id = id;
    }

    public void DisplayInfo(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
    }
}

interface Worker{
    void PerformDuties();
}

class Chef : Person, Worker{
    private string specialty;

    public Chef(string name, int id, string specialty): base(name, id){
        this.specialty = specialty;
    }

    public void PerformDuties(){
        Console.WriteLine("Role: Chef");
        Console.WriteLine("Preparing dishes, specialty: " + specialty);
    }
}

class Waiter : Person, Worker{
    private int tablesAssigned;

    public Waiter(string name, int id, int tablesAssigned): base(name, id){
        this.tablesAssigned = tablesAssigned;
    }

    public void PerformDuties(){
        Console.WriteLine("Role: Waiter");
        Console.WriteLine("Serving customers at " + tablesAssigned + " tables");
    }
}

class RestaurantManagementSystem{
    static void Main(string[] args){
        Worker chef = new Chef("Arjun", 101, "Italian Cuisine");
        Worker waiter = new Waiter("Rohit", 102, 5);

        chef.PerformDuties();
        Console.WriteLine();

        waiter.PerformDuties();
    }
}
