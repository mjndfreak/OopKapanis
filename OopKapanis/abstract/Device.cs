namespace OopKapanis;

public abstract class BaseDevice
{
    public BaseDevice()
    {
        ProductionDate = DateTime.Today;
    }
    
    
    public DateTime ProductionDate { get; set; }
    public string SerialNumber { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string OperationSystem { get; set; }

    public virtual string Info()
    {
        return @"ProductionDate: " + ProductionDate +
               "\nSerialNumber: " + SerialNumber +
               "\nName: " + Name +
               "\nDescription: " + Description +
               "\nOperationSystem: " + OperationSystem;
    }

    public abstract void PrintProductName();
}

