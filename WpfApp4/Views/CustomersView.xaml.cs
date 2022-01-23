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
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    /// 
    
    public partial class CustomersView : UserControl

    {
	  private readonly SqlService sqlService = new SqlService();
	  public void GetCustomersList()
	  {
		//Customer..Clear();

	
		foreach (var item in sqlService.GetCustomers())
		{
		    
		    lvUsersView.Items.Add(item);
		    
		}
		foreach ( var item in sqlService.GetAddresses())
		{
		    lvUsersView.Items.Add(item);
		}
	  }


	
	  public CustomersView()
	  {
		InitializeComponent();
		lvUsersView.Items.Clear();
		GetCustomersList();
	

	  }
    }
}
