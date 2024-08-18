
using OopKapanis.concrete;



List<Computer> computersList = new List<Computer>();
List<Phone> phonesList = new List<Phone>();

while (true)
{
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 1)
    {
        Computer computer = new Computer();
        Console.Write("Name: ");
        computer.Name = Console.ReadLine();
        Console.Write("Description: ");
        computer.Description = Console.ReadLine();
        Console.Write("OperationSystem: ");
        computer.OperationSystem = Console.ReadLine();
        Console.Write("SerialNumber: ");
        computer.SerialNumber = Console.ReadLine();
        Console.Write("Bluetooth: (yes/no) ");
        computer.Bluetooth = Console.ReadLine();
        Console.Write("UsbCount: (2/4) ");
        computer.UsbCount = int.Parse(Console.ReadLine());
        

        computersList.Add(computer);
    }
    else if (answer == 2)
    {
        Phone phone = new Phone();
        Console.Write("Name: ");
        phone.Name = Console.ReadLine();
        Console.Write("Description: ");
        phone.Description = Console.ReadLine();
        Console.Write("OperationSystem: ");
        phone.OperationSystem = Console.ReadLine();
        Console.Write("SerialNumber: ");
        phone.SerialNumber = Console.ReadLine();
        Console.Write("TrLicence: (yes/no) ");
        phone.TrLicence = Console.ReadLine();
        
        phonesList.Add(phone);
    }
    else
    {
        Console.WriteLine("Error");
    }

    Console.Write("Do you want to add another device ? (y/n)");
    string answer2 = Console.ReadLine();
    
    if (answer2 == "y");
    
    else
    {
        Console.WriteLine("Bye!");
        break;
    }

}

foreach (var info in computersList)
{
    Console.WriteLine(info);
}

foreach (var info in phonesList)
{
    Console.WriteLine(info);
}

