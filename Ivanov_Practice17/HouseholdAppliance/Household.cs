public abstract class HouseholdAppliance
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }

    public HouseholdAppliance(string brand, string model, double price)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }

    public abstract void SwitchOn();
    public abstract void SwitchOff();
}

public class Refrigerator : HouseholdAppliance
{
    public double Temperature { get; set; }

    public Refrigerator(string brand, string model, double price, double temperature)
        : base(brand, model, price)
    {
        Temperature = temperature;
    }

    public override void SwitchOn()
    {
        // Logic to switch on the refrigerator
    }

    public override void SwitchOff()
    {
        // Logic to switch off the refrigerator
    }

    public void SetTemperature(double temperature)
    {
        // Logic to set the temperature of the refrigerator
        Temperature = temperature;
    }
}
