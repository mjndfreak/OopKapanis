namespace OopKapanis.concrete;

public class Computer : BaseDevice
{
    private int _usbCount;

    public int UsbCount
    {
        get
        {
            return _usbCount;
        }
        set
        {
            if (value == 2 || value == 4 )
            {
                _usbCount = value;
            }
            else
            {
                _usbCount = -1;
                Console.WriteLine("Error !! Usb Count assigned -1");
            }
        }
    }

    private string _bluetooth;

    public string Bluetooth
    {
        get
        {
            return _bluetooth;
        }
        set
        {
            if (value == "yes" || value == "no")
            {
                _bluetooth = value;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    public override string  Info()
    {
        
        if (Bluetooth == "yes")
        {
            return  base.Info() +
                    "\nUsb Count: " + _usbCount +
                    "\nBluetooth: Yes";
        }
        else
        {
            return base.Info() +
                   "\nUsb Count: " + _usbCount +
                   "\nBluetooth: No";
        }
    }

    public override void PrintProductName()
    {
        Console.WriteLine("Name of your computer is: " + Name);
    }

    public override string ToString()
    {
        return Info();
    }
}