namespace Interfaces.Services
{
    class PaypalService : IPaymentService
    {
        private double _interestTax = 0.01;
        private double _paymentFee = 0.02;

        public double SimplePaymentInterest(double amount, int months)
        {
            return amount * _interestTax * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * _paymentFee;
        }
    }
}
