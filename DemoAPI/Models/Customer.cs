using System.Collections.Generic;
using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;

namespace DemoAPI.Models
{
  public class Customer
  {
    public int ID { get; set; }
    public string Name { get; set; }
  }
}
