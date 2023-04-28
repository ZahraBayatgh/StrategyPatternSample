public interface IShippingStrategy
{
    double CalculateShippingCost(double orderTotal);
}
public class StandardShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(double orderTotal)
    {
        return orderTotal * 0.1; // 10% of the order total
    }
}

public class ExpressShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(double orderTotal)
    {
        return orderTotal * 0.2; // 20% of the order total
    }
}

public class NextDayShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(double orderTotal)
    {
        return orderTotal * 0.3; // 30% of the order total
    }
}