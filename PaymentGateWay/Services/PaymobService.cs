using Newtonsoft.Json;
using PaymentGateWay.Services;
using System.Text;

namespace PaymentGateWay.Models
{
    public class PaymobService : IPaymobService
    {
        private readonly HttpClient _httpClient;
        private readonly string _paymobBaseUrl = "https://accept.paymob.com/api/";
        private readonly string _secretKey = "ZXlKaGJHY2lPaUpJVXpVeE1pSXNJblI1Y0NJNklrcFhWQ0o5LmV5SmpiR0Z6Y3lJNklrMWxjbU5vWVc1MElpd2ljSEp2Wm1sc1pWOXdheUk2T1RjeE5Ea3lMQ0p1WVcxbElqb2lhVzVwZEdsaGJDSjkuYnZXelpZRExIYThoN1VkcmRzS1F4YV9YVXEyU211dFZBOW1vdF9UWVlfNUw5YzE2MWFIYXRKNXhtT0FmYkp1SkVfUFhoRkpBaG5GckxWVkhzNjRrLXc=";

        public PaymobService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri(_paymobBaseUrl);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_secretKey}");
        }

        public async Task<AuthResponseModel> InitiatePayment(int ID, decimal amount)
        {
            var paymentRequest = new
            {
                amount_cents = (int)(amount * 100), 
                currency = "EGP", 
            };
            var json = JsonConvert.SerializeObject(paymentRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("acceptance/payment_keys", content);

            response.EnsureSuccessStatusCode(); // Throws exception for non-success status codes

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AuthResponseModel>(responseContent);
        }
    }
}
