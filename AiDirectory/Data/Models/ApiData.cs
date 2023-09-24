using System.Text.Json.Serialization;
namespace AiDirectory.Data;
public class ApiData
{
    public int Id { get; set; }
    public string Name { get; set; }

    [JsonPropertyName("pricing_model")]
    public string PricingModel { get; set; }

    public string Description { get; set; }

    [JsonPropertyName("additional_info")]
    public string AdditionalInfo { get; set; }

    [JsonPropertyName("final_url")]
    public string FinalUrl { get; set; }
}
