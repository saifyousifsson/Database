using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    public enum Statuses
    {
	  Registered = 1,
	  Investigating = 2,
	  Closed = 3,
    }
    internal class Case
    {
	
	  public string Rubrik { get; set; } = null!;
	
	  public string Beskrivning { get; set; } = null!;
	
	  public string skapades_date { get; set; } = null!;

	  public string Andrades_Date { get; set; } = null!;
	  public int CustomerId { get; set; }
	  public Statuses Status { get; set; }
    }
}
