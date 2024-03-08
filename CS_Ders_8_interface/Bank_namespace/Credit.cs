using CS_Ders_8_interface.GuId_namespace;

namespace CS_Ders_8_interface.Bank_namspace;

public class Credit : Base_class, IGuId
{
    private string guid = Guid.NewGuid().ToString();
    public int amount;
    public double percent;
    public int months;
    public double payment;
    public double claculate_percent;

    public Credit(int amount, double percent, int months, double payment, double claculate_percent)
    {
        Months = amount;
        Percent = percent;
        Months = months;
        Payment = payment;
        Calculate_percent = claculate_percent;
    }

    public string guId => guid;
    public int Amount
    {
        get { return amount; }
        set { amount = value; }
    }


    public double Percent
    {
        get { return percent; }
        set { percent = value; }
    }

    public int Months
    {
        get { return months; }
        set { months = value; }
    }

    public double Payment
    {
        get { return payment; }
        set { payment = value; }
    }

    public double Calculate_percent
    {
        get { return claculate_percent; }
        set { claculate_percent = value; }
    }


    public void Show_Credit_info()
    {
        Console.WriteLine();
    }


    public override void Show()
    {
        Console.WriteLine($"Guid - {guid}\n");
        base.Show();

    }









}
