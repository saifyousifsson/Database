using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for CaseView.xaml
    /// </summary>
    public partial class CaseView : UserControl
    {   private readonly SqlService sqlService= new SqlService();
	  public void GetCaseList()
	  {



	  }

	  


	  public CaseView()
	  {
		InitializeComponent();
		//GetCaseList();
	
		lvCaseView.Items.Clear();
		foreach (var user in sqlService.GetcaseList())
		{
		    lvCaseView.Items.Add(user);
		}
	

		



	  }

	

    }
  //  private void PopulateRoles()
  //  {
	//  .Items.Clear();
	 // foreach (var role in roleService.GetAll())
	//	cbRole.Items.Add(new KeyValuePair<int, string>(role.Id, role.Name));
  //  }
}
