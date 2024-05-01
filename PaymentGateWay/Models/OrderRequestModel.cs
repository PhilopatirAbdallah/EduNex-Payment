using System.ComponentModel.DataAnnotations;

namespace PaymentGateWay.Models
{
    public class OrderRequestModel
    {
        [Required]
        public string AuthToken { get; set; }
        private bool DeliveryNeeded { get; } = false;
        private int _amountCents;

        public int AmountCents
        {
            get => _amountCents;
            set => _amountCents = value * 100;
        }
        private string Currency { get; } = "EGP";
        private string[] Items { get; } = Array.Empty<string>();
    }
}
