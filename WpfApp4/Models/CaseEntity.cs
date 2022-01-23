using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    internal class CaseEntity
    {
	[ Key]
	  public int Id { get; set; }
	  [Required]
	  [StringLength(50)]
	  public string Rubrik { get; set; } = null!;
	  [Required]
	  [MaxLength]
	  public string Beskrivning { get; set; } = null!;
	  [Required]
	  [StringLength(50)]
	  public string skapades_date { get; set; } = null!;
	  [Required]
	  [StringLength(50)]
	  public string Andrades_Date { get; set; } = null!;
	  [Required]
	  public int CustomerId { get; set; }

	  [Required]
	  public string Status { get; set; } = null!;
	  public virtual ICollection<CustomerEntity> Customers { get; set; } = new List<CustomerEntity>();


    }
}
