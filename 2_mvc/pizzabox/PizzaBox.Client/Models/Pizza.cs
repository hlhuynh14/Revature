using System.Collections.Generic;

namespace PizzaBox.Client.Models
{
  public class Pizza
  {
    public string Crust { get; set; }
    public string Size { get; set; }
    public List<string> Crusts { get; set; }
    public List<string> Sizes { get; set; }

    public Pizza()
    {
      Crusts = new List<string> { "thin", "nystyle", "deepdish" };
      Sizes = new List<string> { "small", "medium", "large" };
    }
  }
}
