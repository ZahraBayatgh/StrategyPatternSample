public class ShippingCalculator
{


    private readonly IShippingStrategy _shippingStrategy;

    public ShippingCalculator(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public double CalculateShippingCost(double orderTotal)
    {
        return _shippingStrategy.CalculateShippingCost(orderTotal);
    }
}