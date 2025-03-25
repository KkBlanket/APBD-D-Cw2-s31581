namespace APBD_D_Cw2_s31581;

public class CoolingContainer : Container
{ 
    public List<Owoc> _products = new List<Owoc>();
    public int temperature;
    public Type dozwolonyTyp;
    
    public CoolingContainer(int temperature)
    {   
        this.temperature = temperature;
        serialnumber = $"{serialnumber}C-{counter++}";
    }

    public void load(double load, Owoc productType)
    {
        if (_products.Count == 0)
        {
            dozwolonyTyp = productType.GetType();
        }
        
        if (productType.GetType() == dozwolonyTyp)
        {
            if (temperature >= productType.temperature)
            {
                _products.Add(productType);
                Console.WriteLine($"{productType.nazwa} dodano do kontenera.");
            }
            else
            {
                Console.WriteLine($"Temperatura kontenera jest za niska dla {productType.nazwa}.");
            }
        }
        else
        {
            Console.WriteLine($"Można przechowywać tylko produkty typu {dozwolonyTyp.Name} w tym kontenerze.");
        }
    }
}