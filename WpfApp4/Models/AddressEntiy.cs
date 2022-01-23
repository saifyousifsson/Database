using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    internal class AddressEntiy
    {
	  [Key]
	  public int Id { get; set; }
	  [Required]
	  [StringLength(50)]
	  public string StreetName { get; set; } = null!;
	  [Required]
	  [StringLength(5)]
	  public string PostalCode { get; set; } = null!;
	  [Required]
	  [StringLength(50)]
	  public string City { get; set; } = null!;
	  [Required]
	  [StringLength(50)]
	  public string Country { get; set; } = null!;
	  [Required]
	  public int CustomerId { get; set; }
	  public virtual ICollection<CustomerEntity> Customers { get; set; } = new List<CustomerEntity>();

    }
}
