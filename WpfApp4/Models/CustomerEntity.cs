using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    [Index(nameof(Email), IsUnique = true)]
    internal class CustomerEntity
    {   
	  [Key]
	  public int Id { get; set; }
	  [Required]
	  [StringLength(50)]
	  public string FirstName { get; set; } = null!;
	  [Required]
	  [StringLength(50)]
	  public string LastName { get; set; } = null!;
	  [Required]
	  [StringLength(100)]
	  [Unicode(false)]
	  public string Email { get; set; } = null!;
	  [Required]
	  [StringLength(10)]
	  public string MobilNumber { get; set; } = null!;
	  [Required]
	  public int AddressId { get; set; }
	  public string DisplayName => $"{FirstName}{LastName}";
	  // public virtual AddressEntiy Address { get; set; } = null!;
	  public virtual AddressEntiy Address { get; set; } = null!;
    }
}
