namespace APBD_D_Cw2_s31581;

public abstract class Container : IHazardNotifier
{
    static public int counter = 1; 
    public double mass;
    public double containerMass;
    public double height;
    public double depth;
    public String serialnumber = "KON-";
    public double maxLoad;
    public Container()
    {
        height = 300;
        containerMass = 1000;
    }

    public virtual void unload()
    {
        mass = 0;
    }

    public virtual void load(double load)
    {
        if (load > maxLoad)
            throw new OverfillException("towar za duzy");
        mass = load;
    }

    public void warn(String serialnumber)
    {
        Console.WriteLine($"Container {serialnumber} warn");
    }

    public override string ToString()
    {
        return $"Container number: {serialnumber}";
    }
}