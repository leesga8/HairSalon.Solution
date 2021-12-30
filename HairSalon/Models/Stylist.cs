using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public DateTime DateHired { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

    public Specialty StylistSpecialty { get; set; }
  }
  public enum Specialty
  {
    Perm,
    Balage
    // Curly,
    // Fade
  }
}