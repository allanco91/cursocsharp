using System;
using Interfaces.Entities;

namespace Interfaces.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public void ProcessContract(Contract contract, int installmentsNumber)
        {
            _paymentService = new PaypalService();
            
            double amount = contract.TotalValue / installmentsNumber;
            
            for (int i = 1; i <= installmentsNumber; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double paymentInterest = _paymentService.SimplePaymentInterest(amount, i);
                double paymentFee = _paymentService.PaymentFee(amount + paymentInterest);
                double total = amount + paymentInterest + paymentFee;

                Installment installment = new Installment(dueDate, total);
                contract.Installments.Add(installment);
            }
        }
    }
}
