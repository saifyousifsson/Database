﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    internal class Address
    {
	   
	  public string StreetName { get; set; } = null!;
	
	  public string PostalCode { get; set; } = null!;
	
	  public string City { get; set; } = null!;
	
	  public string Country { get; set; } = null!;
	  public virtual Customer Customer { get; set; }
    }
}
