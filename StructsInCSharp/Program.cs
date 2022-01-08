using System;

public struct Customer
{
    private int _id;
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Id={0} && Name= {1}",this._id,this._name);
    }
}
public class Program
    {
    static void Main()
    {
        Customer c1 = new Customer(100, "Rahat");
        c1.PrintDetails();

        Customer c2 = new Customer();
        c2.ID = 102;
        c2.Name = "Faysal";
        c2.PrintDetails();

        Customer c3 = new Customer
        {
            ID = 103,
        Name = "Rashed",
        };
        c3.PrintDetails();

    }
    }

