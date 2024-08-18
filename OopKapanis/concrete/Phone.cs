namespace OopKapanis.concrete;

public class Phone : BaseDevice
{
    private string _trLicence;

    public string TrLicence
    {
        get
        {
            return _trLicence;
        }
        set
        {
            if (value == "yes" || value == "no")
            {
                _trLicence = value;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    public override string Info()
    {
        if (TrLicence == "yes")
        {
            return base.Info() +
                   "\nTr Licence: Yes";
        }
        else
        {
            return base.Info() +
                   "\nTr Licence: No";
        }
    }

    public override void PrintProductName()
    {
        Console.WriteLine(" Name of your phone is: " + Name);
    }

    public override string ToString()
    {
        return Info();
    }
}