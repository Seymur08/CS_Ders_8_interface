namespace CS_Ders_8_interface;
using Bank_namespace;
using CS_Ders_8_interface.GuId_namespace;

public class Manager : Base_class,IBase,IGuId
{
    private string guid = Guid.NewGuid().ToString();
  

    public Manager(string name, string surname, int age, string position, int salary)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;


    }

    public string guId => guid;
    public override string Name { get => base.Name; set => base.Name = value; }
    public override string Surname { get => base.Surname; set => base.Surname = value; }
    public override int Age { get => base.Age; set => base.Age = value; }
    public override string Position { get => base.Position; set => base.Position = value; }
    public override int Salary { get => base.Salary; set => base.Salary = value; }

    public void Organize() { Console.WriteLine("Organize"); }

    public void Calculate_Salary(int salary) { Console.WriteLine("Calculate_Salary"); }

    public override void Show() 
    {
        Console.WriteLine($"Guid - {guid}\n");
        base.Show();

    }

}
