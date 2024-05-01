namespace PaymentGateWay.Models
{
    public class BaseResponseWithDataModel <T>
    {
        public T Data { get; set; }
        
        public string ErrorMsg { get; set; }
    }
}
