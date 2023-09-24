using System.Net.Http;
using System.Threading.Tasks;
using AiDirectory.Data;
using Microsoft.Extensions.Logging;

namespace AiDirectory.Data.Services
{
    public interface IToolService
    {
        Task<ApiData[]> GetTools(ApiParameters apiParameters);
    }

    public class ToolService : IToolService
    {
        private readonly HttpClient _http;
        private readonly ILogger<ToolService> _logger;

        public ToolService(HttpClient http, ILogger<ToolService> logger)
        {
            _http = http;
            _logger = logger;
        }

        public async Task<ApiData[]> GetTools(ApiParameters apiParameters)
        {
            var url = $"https://ai.amertech.online/tools?skip={apiParameters.Skip}&limit={apiParameters.Limit}&additional_info={apiParameters.AdditionalInfo}&pricing_model={apiParameters.PricingModel}&search_term={apiParameters.SearchTerm}";
            try
            {
                return await _http.GetFromJsonAsync<ApiData[]>(url);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError("Error fetching tools from API: {Error}", ex.Message);
                throw; // You can rethrow the exception or handle it differently based on your requirements.
            }
        }
    }
}