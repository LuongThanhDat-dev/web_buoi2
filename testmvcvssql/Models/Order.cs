namespace testmvcvssql.Models;
public class Order {
    public int id { get; set; }
    public  decimal Total { get; set; }
    public DateTime OrderTime { get; set; }
}