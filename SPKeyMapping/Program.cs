using System.IO.Ports;

class Program
{
    static string comPort = "dev/ttyACM0";
    static SerialPort serialPort = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);

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
        Console.WriteLine(serialPort.ReadExisting());
    }
}

