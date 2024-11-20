namespace Patterns_Demo.Adapter_Pattern_Example.Models;

public class Location
{
    public Street? Street { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public int? Postcode { get; set; }
    public Coordinates? Coordinates { get; set; }
    public Timezone? Timezone { get; set; }
}