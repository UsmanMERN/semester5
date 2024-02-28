


using System.Security.Cryptography;

public class OOP
 {

    public static void Main(string[] args){

       Human human1 = new Human("hello",12);
    Human human2 = new Human("World",21);


    


        human1.Eat();
        human1.Sleep(); 

        human2.Eat();
        human2.Sleep();


        Console.ReadLine(); 
    }


 }

class Human
{
    public string name;
    public int age;


    public Human(string name,int age) {
        this.name = name;
        this.age = age;
    }


    public void Eat()
    {
        Console.WriteLine(name+" is eating");
    }

    public void Sleep ()
    {
        Console.WriteLine(name+" is sleeping an his age is "+age);
    }
}

