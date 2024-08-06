namespace GpuSimpleFactory;

public class Program
{
    public static void Main (string[] args)
    {
        MsiManufacture msiManufacture = new MsiManufacture();
        msiManufacture.AssempleGpu();

        AsusManufacture asusManufacture = new AsusManufacture();
        asusManufacture.AssempleGpu();

        Console.ReadLine();
    }
}
