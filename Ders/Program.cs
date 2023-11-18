/*
MyClass m = new MyClass{
    MyProperty = 5
};

MyClass m1 = new MyClass{
    MyProperty = 5
};
MyRecord m2 = new MyRecord{
    MyProperty= 3
};
MyRecord m3 = new MyRecord{
    MyProperty= 3
};

System.Console.WriteLine(m.Equals(m1));
System.Console.WriteLine(m2.Equals(m3));

//Recordlar aynı değeri gösterdikçe true değeri döner 
//Ama sınıflar farklı nesne olarak davrandığı için  false değerini dönerler

class MyClass{
    public int MyProperty { get; set; }
}

record MyRecord{
    public int MyProperty { get; set; }
    public int MyProperty2 { get; set; }
}

//--------------------
MyRecord m = new MyRecord(){
    MyProperty= 5,
    MyProperty2= 10
};
MyRecord m2 = m with {MyProperty2=15};

class MyClass{
    public int MyProperty { get; set; }
}

record MyRecord{
    public int MyProperty { get; set; }
    public int MyProperty2 { get; set; }
}

//--CONSTRUCTOR

 new MyClass();
 new MyClass();
 
class MyClass{
    public MyClass(){
        System.Console.WriteLine("constructor çalişti");        
    }
    static MyClass(){
        System.Console.WriteLine("static constructor çalişti");
    }
    }
//Static construct'ın tetiklenebilmesi için illa ilk nesne üretimi
//yapılmasına gerek yoktur. İlgili sınıf içerisinde herhangi bir static
//yapılanmanında tetiklenmesi static cosnt. tetiklenmesini sağlayacaktır.
//------------------

//--KALITIM

Software m1 = new Software();
m1.İsim = "batuhan";
System.Console.WriteLine(m1.İsim);
public class Personal{
    public int Id { get; set; }
    public string? İsim { get; set; }
    public string? Soyisim { get; set; }
}


S
class Software : Personal
{

}
class müdür : Personal
{

}

class Manager : Personal
{

}
*/

 class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}