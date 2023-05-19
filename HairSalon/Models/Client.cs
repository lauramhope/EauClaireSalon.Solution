namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string LastName { get; set; }
    public int Birthday { get; set; }

    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }

  }
}