// This can be placed in a file within a Models or Entities directory.
public class MarketQuote
{
    public int Id { get; set; }
    public DateTime QuoteDate { get; set; }
    public string Broker { get; set; }
    public string CUSIP { get; set; }
    public string Bond { get; set; }
    public int Size { get; set; }
    public string Actions { get; set; }
    public decimal Price { get; set; }
}
