namespace Interfaces.Services
{
    interface IPaymentService
    {
        public double SimplePaymentInterest(double amount, int months);
        public double PaymentFee(double amount);
    }
}
