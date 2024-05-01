using PaymentGateWay.Models;

namespace PaymentGateWay.Services
{
    public interface IPaymobService
    {
        Task<AuthResponseModel> InitiatePayment(int Id, decimal amount);
    }
}
