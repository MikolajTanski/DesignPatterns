namespace Builder;

public class Invoice
{
    public string Number { get; set; }
    public DateTime Date { get; set; }
    public string Vendor { get; set; }
    public string Vandee { get; set; }
    public IEnumerable<string> LineItems { get; set; }
    public string Note { get; set; }
}