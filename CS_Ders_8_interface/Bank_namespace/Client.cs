using CS_Ders_8_interface.GuId_namespace;
using System;

namespace CS_Ders_8_interface.Bank_namspace;

public class Client : Base_class, IGuId
{
    private string guid = Guid.NewGuid().ToString();

    public string live_address;
    public string work_address;
    public Client(string name, string surname, int age, string live_address, string work_address, int salary)
    {

        Name = name;
        Surname = surname;
        Age = age;
        Live_address = live_address;
        Work_address = work_address;
        Salary = salary;
    }

    public string guId => guid;
    public string Live_address
    {
        get { return live_address; }
        set { live_address = value; }
    }


    public string Work_address
    {
        get { return work_address; }
        set { work_address = value; }
    }

    public override string Name { get => base.Name; set => base.Name = value; }
    public override string Surname { get => base.Surname; set => base.Surname = value; }
    public override int Age { get => base.Age; set => base.Age = value; }
    public override int Salary { get => base.Salary; set => base.Salary = value; }

    public override void Show()
    {
        Console.WriteLine($"Guid - {guid}\nName - {Name}\nSurname - {Surname}\nAge - {Age}\nLive_address - {Live_address}\nWork_address - {Work_address}\nSalary - {base.Salary}");
        Console.WriteLine("*********************************************\n");
    }

}
