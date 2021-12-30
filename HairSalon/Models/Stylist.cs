using System.Collections.Generic;
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
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
  }
}