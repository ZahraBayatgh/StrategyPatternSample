using static ShippingType;

double orderTotal = 100.0;
ShippingType shippingType = Standard;


switch (shippingType)
{
    case Standard:
        {
            // Using Standard Shipping
            var standardShippingCalculator = new ShippingCalculator(new StandardShippingStrategy());
            Console.WriteLine($"Standard Shipping Cost: {standardShippingCalculator.CalculateShippingCost(orderTotal)}");
            break;
        }
    case Express:
        {
            // Using Express Shipping
            var expressShippingCalculator = new ShippingCalculator(new ExpressShippingStrategy());
            Console.WriteLine($"Express Shipping Cost: {expressShippingCalculator.CalculateShippingCost(orderTotal)}");
            break;
        }

    case NextDay:
        {
            // Using Next Day Shipping
            var nextDayShippingCalculator = new ShippingCalculator(new NextDayShippingStrategy());
            Console.WriteLine($"Next Day Shipping Cost: {nextDayShippingCalculator.CalculateShippingCost(orderTotal)}");
            break;
        }
}

