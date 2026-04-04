using System;
using System.Reflection;

class Person
{
    private int age;

    public Person()
    {
        age = 20;
    }
}

class PrivateFieldManipulation
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);

        FieldInfo field = type.GetField(
            "age",
            BindingFlags.NonPublic | BindingFlags.Instance
        );

        field.SetValue(person, 35);

        object value = field.GetValue(person);
        Console.WriteLine(value);
    }
}
