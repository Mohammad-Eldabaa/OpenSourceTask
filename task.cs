using System;
namespace oop;

class Oop
{

    private static void Main()
    {

        Console.WriteLine("HOllo, world");

        var stu_1 = new Student("mohammad", 20, 2002, 3.3f);
        stu_1.Print();

        var stu_2 = new Staf ("ramadan", 20, 5000, 2002);
        stu_2.Print();

        var stu_3 = new Person("eldabaa", 20);
        stu_3.Print();

        var printA = new Database();
        printA.printall();
    }   
}


//____________________________________________________________________

public  class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age  = age;
    }

    public virtual void Print()
    {
        Console.WriteLine("My name is " + Name + ", my age is " + Age );
    }

}

//-------------------------------------------------------------

public class Student : Person
{

    public int Year;
    public float Gpa;
    public Student (string name, int age, int year, float gpa) : base(name, age)
    {
            Year = year;
            Gpa = gpa;
    }

    public override void Print()
    {
            Console.WriteLine($"my name is {Name} and my age is {Age}");
            Console.WriteLine($"my gpa is {Gpa} and I have born in {Year}");
    }
}

//___________________________________________________________________

public class Database
{
    public Person[] poeple= new Person[20];
    private int _current = 0;


    public void addStudent(Student student)
    {
        poeple [_current] = student;
        _current++;
    }

    public void addStaf(Staf staf)
    {
        poeple [_current] = staf;
        _current++;
    }

    public void printall()
    {
        for(var i=0 ; i<_current; i++)
        {
            poeple[i].Print();
        }
    }
}

//_________________________________________________________________


public class Staf : Person
{

    private double Salary;
    private int Year;

//(string name, int age, int year, float gpa) : base(name, age)

    public Staf (string name, int age, double salary, int year) : base (name, age)
    {
        Salary = salary;
        Year = year;
    }

    public override void Print()
    {

            Console.WriteLine("My name is " + Name + ", my age is " + Age + " and my salary is " + Salary);
    }


}