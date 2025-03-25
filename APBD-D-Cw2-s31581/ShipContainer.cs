namespace APBD_D_Cw2_s31581;

public class ShipContainer
{
    List<Container> containers = new List<Container>();
    public int speed;
    public int maxContainers;
    public int maxmass;

    public ShipContainer(int speed, int maxContainers)
    {
        this.speed = speed;
        this.maxContainers = maxContainers;
    }

    public void listContainers()
    {
        foreach (var Container in containers)
        {
            Console.WriteLine(Container);
        }
    }

    public void addContainer(Container container)
    {
        if (containers.Count > maxContainers)
            Console.WriteLine("Too many containers");
        else
            containers.Add(container);
    }
    public void addContainer(List<Container> container)
    {
        if (containers.Count+container.Count > maxContainers)
            Console.WriteLine("Too many containers");
        else
            containers.AddRange(container);
    }

    public void removeContainer(Container container)
    {
        containers.Remove(container);
    }

    public void swapContainers(String serialnumber1, String serialnumber2)
    {
        var container1 = containers.Find(x => x.serialnumber == serialnumber1);
        var container2 = containers.Find(x => x.serialnumber == serialnumber2);
        if (containers.Contains(container2))
            Console.WriteLine($"{container2} already contained");
        else if (!containers.Contains(container1))
        {
            Console.WriteLine($"{container1} not contained");
        }
        else
        {
            containers.Remove(container1);
            containers.Add(container2);
        }
}

    public override string ToString()
    {
        Console.WriteLine("{0} speed, {1} maxContainers, {2} maxmass", speed, maxContainers, maxmass);
        foreach (Container container in containers)
        {
            Console.WriteLine(container.ToString());
        }

        return "";
    }
}