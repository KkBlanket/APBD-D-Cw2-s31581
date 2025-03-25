namespace APBD_D_Cw2_s31581;

public class GasContainer : Container
{
    public GasContainer()
    {
        serialnumber = $"{serialnumber}G-{counter++}";
    }

    public override void unload()
    {
        mass *= 0.05;
    }

    public override void load(double load)
    {
        if (load > mass)
            throw new OverfillException("Towar jest za duży");
        base.load(load);
    }
}