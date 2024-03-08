using CS_Ders_8_interface.GuId_namespace;

namespace CS_Ders_8_interface;

public class Worker : Base_class,IGuId
{
    private string guid = Guid.NewGuid().ToString();

    public string start_time;
    public string end_time;

    public Worker(string name, string surname, int age, string position, int salary, string start_time, string end_time)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
        this.start_time = start_time;
        this.end_time = end_time;
    }


    public string guId => guid;
    public override string Name { get => base.Name; set => base.Name = value; }
    public override string Surname { get => base.Surname; set => base.Surname = value; }
    public override int Age { get => base.Age; set => base.Age = value; }
    public override string Position { get => base.Position; set => base.Position = value; }
    public override int Salary { get => base.Salary; set => base.Salary = value; }


    public string Start_time
    {
        get { return start_time; }
        set { start_time = value; }
    }

    public string End_time
    {
        get { return end_time; }
        set { end_time = value; }
    }

    

    public override void Show()
    {

        Console.WriteLine($"Start Time - {Start_time}\nEnd Time - {End_time}\n");
        Console.WriteLine($"Guid - {guid}\n");
        base.Show();
        
    }

    public void Operation(int[] num) { Console.WriteLine("Operation"); }

    public void Add_Operation() { Console.WriteLine("Add_Operation"); }








}
