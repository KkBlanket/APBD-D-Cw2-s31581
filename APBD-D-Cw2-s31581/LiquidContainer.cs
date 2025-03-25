namespace APBD_D_Cw2_s31581;

public class LiquidContainer : Container
{
    public bool containDangerousitem;
    public LiquidContainer(bool dangerousitem)
    {
        containDangerousitem = dangerousitem;
        serialnumber = $"{serialnumber}L-{counter++}";
    }

    public override void load(double load)
    {
        if (containDangerousitem)
        {
            maxLoad *= 0.5;
        }
        else
        {
            maxLoad *= 0.9;
        }
        if(load > maxLoad)
            warn(serialnumber);
        base.load(load);
    }
}