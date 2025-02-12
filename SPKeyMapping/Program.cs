using System.IO.Ports;

class Program
{
    static string comPort = "COM4";
    static readonly SerialPort serialPort = new(comPort, 9600, Parity.None, 8, StopBits.One);

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    private void Run()
    {
        serialPort.DataReceived += new SerialDataReceivedEventHandler(spDataReceived);
        serialPort.Open();
        Console.Read();
    }

    private void spDataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        string data = serialPort.ReadExisting().Trim();

        Console.WriteLine(data);

        if (data == "1")
        {
            Console.WriteLine("Vrooom slower");
        }
        else if (data == "2")
        {
            Console.WriteLine("Vrooom forward");
        }
        else if (data == "3")
        {
            Console.WriteLine("Vrooom to the left");
        }
        else if (data == "4")
        {
            Console.WriteLine("Vrooom to the right");
        }

    }
}

