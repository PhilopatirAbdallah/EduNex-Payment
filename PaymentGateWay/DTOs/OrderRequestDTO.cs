using System.ComponentModel.DataAnnotations;

namespace PaymentGateWay.DTOs
{
    public class OrderRequestDTO
    {
        public string AuthToken { get; set; }
        public readonly bool DeliveryNeeded  = false;
        public int _amountCents;

        public int AmountCents
        {
            get => _amountCents;
            set => _amountCents = value * 100;
        }
        public readonly string Currency = "EGP";
        public readonly string[] Items = Array.Empty<string>();
    }
}
