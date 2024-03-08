using CS_Ders_8_interface.GuId_namespace;


namespace CS_Ders_8_interface.Bank_namespace;

public class Operation : Base_class, IGuId
{
    private string guid = Guid.NewGuid().ToString();
    public string date_time;
    public string prosess_name;

    public Operation(string date_time, string prosess_name)
    {
        Date_time = date_time;
        Prosess_name = prosess_name;
    }

    public string guId => guid;
    public string Date_time
    {
        get { return date_time; }
        set { date_time = value; }
    }

    public string Prosess_name
    {
        get { return prosess_name; }
        set { prosess_name = value; }
    }


    public override void Show()
    {
        Console.WriteLine($"Guid - {guid}\n");
        base.Show();

    }
}
