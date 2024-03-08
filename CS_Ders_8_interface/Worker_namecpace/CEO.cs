namespace CS_Ders_8_interface;
using Bank_namespace;
using CS_Ders_8_interface.GuId_namespace;

public class CEO : Base_class,IBase,IGuId
{
    private string guid = Guid.NewGuid().ToString();
    public CEO(string name, string surname, int age, string position, int salary)
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

    public override void Show()
    {
        Console.WriteLine($"Guid - {guid}\n");
        base.Show();

    }
    public void Control() { Console.WriteLine("Control"); }

    public void Make_Meeting() { Console.WriteLine("Make_Meeting"); }

    public void Organize() { Console.WriteLine("Organize"); }

    public void Decrease_persentage(int persentage) { Console.WriteLine("decrease_persentage"); }
}
