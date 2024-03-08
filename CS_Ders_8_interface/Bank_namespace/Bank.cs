using System.ComponentModel;

namespace CS_Ders_8_interface.Bank_namspace;

public class Bank 
{
    public string name;
    public int budget;
    public int profit;

    List<CEO> ceos = new List<CEO>();
    List<Worker> workers = new List<Worker>();
    List<Manager> managers = new List<Manager>();
    List<Client> clients = new List<Client>();

    public Bank(string name, int budget, int profit)
    {
        Name = name;
        Budget = budget;
        Profit = profit;
        
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Budget
    {
        get { return budget; }
        set { budget = value; }
    }

    public int Profit
    {
        get { return profit; }
        set { profit = value; }
    }


    public void Add_Ceo(CEO ceo)
    {
        ceos.Add(ceo);
    }

    public void Add_Worker(Worker worker)
    {
        workers.Add(worker);
    }

    public void Add_Manager(Manager manager)
    {
        managers.Add(manager);
    }

    public void Add_Client(Client client)
    {
        clients.Add(client);
    }

    public void Show_Client_Credit(string name)
    {
        Console.WriteLine("Show_Client_Credit");
    }

    public void Pay_Credit(Client client,int money)
    {
        Console.WriteLine("Pay_Credit");

    }

    public void Show_All_Credit()
    {
        Console.WriteLine("Show_All_Credit");

    }


}
