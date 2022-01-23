using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;

namespace WpfApp4.Dtata
{
    internal class DataContext :DbContext
    {

	  public DataContext()
	  {
	  }
	  public DataContext(DbContextOptions<DataContext> options) : base(options)
	  {
	  }
	  public virtual DbSet<CustomerEntity> Customers { get; set; } = null!;

	  public virtual DbSet<AddressEntiy> Addresses { get; set; } = null!;

	  public virtual DbSet<CaseEntity> Cases { get; set; } = null!;
	

	  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	  {
		if (!optionsBuilder.IsConfigured)
		    optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\info\source\repos\WpfApp4\WpfApp4\Dtata\app4.mdf;Integrated Security=True;Connect Timeout=30");
	  }

    }
}
