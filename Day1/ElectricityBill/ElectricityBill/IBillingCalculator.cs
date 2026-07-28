public interface IBillingCalculator
{
    double CalculateBill(double units, double rate, double fixedCharges);
}