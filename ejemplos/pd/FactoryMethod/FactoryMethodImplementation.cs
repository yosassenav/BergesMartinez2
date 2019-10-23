

// Factory Method

public interface IAirConditioner
{
    void Operate();
}


public class Cooling : IAirConditioner
{
    private readonly double _temperature;
 
    public Cooling(double temperature)
    {
        _temperature = temperature;
    }
 
    public void Operate()
    {
        Console.WriteLine($"Cooling the room to the required temperature of {_temperature} degrees");
    }
}


public class Warming : IAirConditioner
{
    private readonly double _temperature;
 
    public Warming(double temperature)
    {
        _temperature = temperature;
    }
 
    public void Operate()
    {
        Console.WriteLine($"Warming the room to the required temperature of {_temperature} degrees.");
    }
}


public abstract class AirConditionerFactory
{
    public abstract IAirConditioner Create(double temperature);
}

public class CoolingFactory : AirConditionerFactory
{
    public override IAirConditioner Create(double temperature) => new Cooling(temperature);
}


public class WarmingFactory : AirConditionerFactory
{
    public override IAirConditioner Create(double temperature) => new Warming(temperature);
}


public enum Actions
{
    Cooling,
    Warming
}


public class AirConditioner
{
    private readonly Dictionary<Actions, AirConditionerFactory> _factories;
 
    public AirConditioner()
    {
        _factories = new Dictionary<Actions, AirConditionerFactory>
        {
            { Actions.Cooling, new CoolingFactory() },
            { Actions.Warming, new WarmingFactory() }
        };
    }
}


public class AirConditioner
{
    private readonly Dictionary<Actions, AirConditionerFactory> _factories;
 
    public AirConditioner()
    {
        _factories = new Dictionary<Actions, AirConditionerFactory>();
 
        foreach (Actions action in Enum.GetValues(typeof(Actions)))
        {
            var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(Actions), action) + "Factory"));
            _factories.Add(action, factory);
        }
    }
}


public class AirConditioner
{
    //previous constructor code
 
    public IAirConditioner ExecuteCreation(Actions action, double temperature) =>_factories[action].Create(temperature);
}


class Program
{
    static void Main(string[] args)
    {
        var factory = new AirConditioner().ExecuteCreation(Actions.Cooling, 22.5);
        factory.Operate();
    }
}

/* https://code-maze.com/factory-method/*/