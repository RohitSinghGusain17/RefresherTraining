public class CommercialCustomer : IBillingCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharges)
    {
        return ((units * rate) * 1.10) + fixedCharges;
    }
}