using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Artist()
    {
      this.JoinEngineerMachine = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public virtual ICollection<EngineerMachine> JoinEngineerMachine { get; set; }
  }
}

