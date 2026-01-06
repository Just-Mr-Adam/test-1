//Интерфейс устройства
public interface Device
{
    void print(String data);
}

//Конкретные устройства
public class Monitor : Device
{
    public void print(String data)
    {
        Console.WriteLine("Displaying on monitor: " + data);
    }
}

public class Printer : Device
{
    public void print(String data)
    {
        Console.WriteLine("Printing to paper: " + data);
    }
}

//Абстракция вывода
public abstract class Output
{
    protected Device device;

    public Output(Device device)
    {
        this.device = device;
    }

    public abstract void render(String data);
}

//Расширенная абстракция
public class TextOutput : Output
{
    public TextOutput(Device device) : base(device) { }

    public override void render(String data)
    {
        device.print("Text: " + data);
    }
}

public class ImageOutput : Output
{
    public ImageOutput(Device device) : base(device) { }

    public override void render(String data)
    {
        device.print("Image: [Binary data: " + data + "]");
    }
}
