using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Dtata;
using WpfApp4.Models;

namespace WpfApp4.Services
{
    internal class SqlService
    {
	  private readonly DataContext _context = new();
	  public int CreateCustomer(Customer customer)
	  {
		var _customer = _context.Customers.Where(x => x.Email == customer.Email).FirstOrDefault();
		if (_customer == null)
		{
		    var CustomerEntity = new CustomerEntity();
		    CustomerEntity.FirstName = customer.FirstName;
		    CustomerEntity.LastName = customer.LastName;
		    CustomerEntity.Email = customer.Email;
		    CustomerEntity.MobilNumber = customer.MobilNumber;
		    CustomerEntity.AddressId = CreateAddres(customer.Address);
		    _context.Customers.Add(CustomerEntity);
		    _context.SaveChanges();
		    return CustomerEntity.Id;
		}
		return -1;
	  }
	  public int CreateAddres(Address address)
	  {
		var _addres = _context.Addresses.Where(x => x.StreetName == address.StreetName && x.PostalCode == address.PostalCode && x.City == address.City && x.Country == address.Country && x.Id==x.CustomerId).FirstOrDefault();
		if (_addres == null)
		{
		    var AddressEntiy = new AddressEntiy()

		    {
			  
			 // CustomerId=CreateCustomer(AddressEntiy),
			  StreetName = address.StreetName,
			  PostalCode = address.PostalCode,
			  City = address.City,
			  Country = address.Country,
			 // Customers=AddressEntiy.CustomerId
			 // CustomerId = CreateAddres(address.Customer)
			 
		    };
		   
		    _context.Addresses.Add(AddressEntiy);
		    _context.SaveChanges();

		    return AddressEntiy.Id;
		}
		return _addres.Id;

	  }
	  public IEnumerable<AddressEntiy> GetAddresses()
	  {
		return _context.Addresses;
		//return _context.Addresses.Include(x=>x.CustomerId).ToList();
	  }
	  public IEnumerable<CustomerEntity> GetCustomers()
	  {
		return _context.Customers.Include(x => x.Address).ToList();
	  }
	  public AddressEntiy GetAddress(int id)
	  {
		return _context.Addresses.SingleOrDefault(x => x.Id == id);
	  }
	  public CustomerEntity GetCustomer(int id)
	  {
		return _context.Customers.Include(x => x.Address).SingleOrDefault(x => x.Id == id);
	  }
	  public void UpdateCustomer(int id, Customer customer)
	  {
		var item = _context.Customers.Find(id);
		if (item != null && item.Id == id)
		{
		    item.FirstName = customer.FirstName;
		    item.LastName = customer.LastName;
		    item.Email = customer.Email;
		    item.MobilNumber=customer.MobilNumber;
		    customer.Address = customer.Address;
		  //  CaseEntity=CreateCustomer(CaseEntity.);
		    _context.Update(item);
		    _context.SaveChanges();
		}
	  }
	  public void UpdateAddress(int id, Address address)
	  {
		var item = _context.Addresses.Find(id);

		if (item != null && item.Id == id)
		{
		    item.StreetName = address.StreetName;
		    item.PostalCode = address.PostalCode;
		    item.City = address.City;
		    item.Country = address.Country;
		    _context.Update(item);
		    _context.SaveChanges();
		}
	  }
	  public int CreateCase(Case cases)
	  {
		var _case = _context.Cases.Where(x => x.Id==x.CustomerId).FirstOrDefault();
		if (_case == null)
		{
		    var CaseEntity = new CaseEntity();
		    CaseEntity.Andrades_Date = cases.Andrades_Date;
		    CaseEntity.Rubrik = cases.Rubrik;
		    CaseEntity.Beskrivning = cases.Beskrivning;
		    CaseEntity.skapades_date = cases.skapades_date;
		    CaseEntity.Status=cases.Status.ToString();
		    CaseEntity.CustomerId=CaseEntity.Id;
		    CaseEntity.Id = cases.CustomerId;
		    CaseEntity.CustomerId=cases.CustomerId;
		    cases.CustomerId = CaseEntity.CustomerId;
		 //   CaseEntity.Customers = cases.
		   // CaseEntity.CustomerId=CreateCustomer(cases.);
		    _context.Cases.Add(CaseEntity);
		    _context.SaveChanges();
		
		    return CaseEntity.Id;
		}
		return -1;
	  }

	  public IEnumerable<CaseEntity> Getcase()
	  {
		//return _context.Cases;
		return _context.Cases.Where(x=>x.CustomerId==x.Id).ToList();
	  }

	  public IEnumerable<CaseEntity> GetcaseList()
	  {
		return _context.Cases;
	  }
	   public ICollection<CaseEntity> Cases { get; set; }= new List<CaseEntity>();
	    public ICollection<CustomerEntity> customers { get; set; } = new List<CustomerEntity>();
    }
	 
    }  

