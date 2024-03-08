using CS_Ders_8_interface.GuId_namespace;
using System;

namespace CS_Ders_8_interface;

public abstract class Base_class
{
    private string? name;
    private string? surname;
    private int age;
    private string? position;
    private int salary;

    public Base_class()
    {
        name = null;
        age = 0;
        surname = null;
        position = null;
        salary = 0;
    }

    public Base_class(string name,string surname,int age,string position,int salary )
    {
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;

    }

    public virtual string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public virtual int Age
    {
        get { return age; }
        set { age = value; }
    }

    public virtual string Position
    {
        get { return position; }
        set { position = value; }
    }

    public virtual int Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name - {Name}\nSurname - {Surname}\nAge - {Age}\nPosition - {Position}\nSalary - {Salary}");
        Console.WriteLine("*********************************************\n");
    }



}
