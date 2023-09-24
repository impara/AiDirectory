namespace AiDirectory.Data;
public class ApiParameters
{
    public int Skip { get; set; } = 0;
    public int Limit { get; set; } = 10;
    public string AdditionalInfo { get; set; }
    public string PricingModel { get; set; }
    public string SearchTerm { get; set; }
}
