using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4.Models;
using WpfApp4.Services;

namespace WpfApp4.Views
{
    /// <summary>
    /// Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCustomerView : UserControl
    {
	  public CreateCustomerView()
	  {
		InitializeComponent();
		ClearFileds();
		
	  }

	  private void btnAdd_Click(object sender, RoutedEventArgs e)
	  {

		if (!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text)
		    && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbMobilNumber.Text)
		   && !string.IsNullOrEmpty(tbStreetName.Text) && !string.IsNullOrEmpty(tbPostalCode.Text)
		   && !string.IsNullOrEmpty(tbcountry.Text) && !string.IsNullOrEmpty(tbCity.Text))
		{
		    SqlService Createkund = new SqlService();
		   Customer customer = new Customer()
		

		    {   
			  FirstName = tbFirstName.Text,
			  LastName = tbLastName.Text,
			  Email = tbEmail.Text,
			  MobilNumber = tbMobilNumber.Text,
			 Address = new Address()

			  {
			     
				
				City = tbCity.Text,
				StreetName = tbStreetName.Text,
				PostalCode = tbPostalCode.Text,
				Country = tbcountry.Text,
				
			  }
		    };
		    if(Createkund.CreateCustomer(customer) > 0)
			  
		    {
			  ClearFileds();
		    }
		    else
		    {
			  lbEroor.Content = "A user with same email address is alrady exists";
		    }

		}
	  }
	  private void ClearFileds()
	  {
		tbFirstName.Text = "";
		tbLastName.Text = "";
		tbEmail.Text = "";
		tbMobilNumber.Text = "";
		tbStreetName.Text = "";
		tbPostalCode.Text = "";
		tbCity.Text = "";
		tbcountry.Text = "";
		lbEroor.Content = "";
	  }
	  
}
}

