using System;
class Animal{
	protected string name;
	protected int age;

	internal Animal(string name, int age){
		this.name = name;
		this.age = age;
	}

	public virtual void MakeSound(){
		Console.WriteLine("Animal makes a sound");
	}
}

class Dog: Animal{
	internal Dog(string name, int age): base(name, age){}

	public override void MakeSound(){
		Console.WriteLine("Dog Barks");
	}
}

class Cat: Animal{
	internal Cat(string name, int age): base(name, age){}

	public override void MakeSound(){
		Console.WriteLine("Cat Meows");
	}
}

class Bird: Animal{
	internal Bird(string name, int age): base(name, age){}

	public override void MakeSound(){
		Console.WriteLine("Bird Chirps");
	}
}

class AnimalHierarchy{
	static void Main(String[] args){
		Animal animal = new Animal("Animal", 0);
        	Animal dog = new Dog("Boxer", 2);
        	Animal cat = new Cat("Cat", 1);
        	Animal bird = new Bird("Birdy", 1);

        	animal.MakeSound();
        	dog.MakeSound();
        	cat.MakeSound();
        	bird.MakeSound();
	}
}
