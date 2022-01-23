using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using WpfApp4.Dtata;
using WpfApp4.Models;
using WpfApp4.Services;

namespace WpfApp4.Views
{
    /// <summary>
    /// Interaction logic for CreatecaseView.xaml
    /// </summary>
    public partial class CreatecaseView : UserControl
    { 
	  private readonly DataContext _context = new();
	  
	  SqlService sqlService = new SqlService();
	  public CreatecaseView()
	  {

		InitializeComponent();
		cbStatus.SelectedValuePath = "Key";
		cbStatus.DisplayMemberPath = "Value";
		ClearFileds();
		PopulateStatus();

	  }
	  private void btnAdd_Click_1(object sender, RoutedEventArgs e)
	  {

		if (!string.IsNullOrEmpty(tbtitle.Text) && !string.IsNullOrEmpty(tbdescription.Text) &&
		    !string.IsNullOrEmpty(tbDatechanged.Text) && !string.IsNullOrEmpty(tbdatecreated.Text
			))

		{


		  

			var newStatus = (Statuses)Enum.Parse(typeof(Statuses), cbStatus.SelectedValue.ToString());
		    Case ccasees = new Case()
		    {

			  skapades_date = tbdatecreated.Text,
			  Andrades_Date = tbdatecreated.Text,
			  Beskrivning = tbdescription.Text,
			  Rubrik = tbtitle.Text,
			 
		       Status = (Statuses)(int)cbStatus.SelectedValue,
			
				  //  Status = new Status()
				  //  { Int32.Parse(cbStatus.SelectedValue.ToString)}
				  //  { NotStart = cbStatus.SelectedValuePath,
				  //   Waiting=cbStatus.SelectedValuePath,
				  // Finshed=cbStatus.SelectedValuePath}

			    };
		    if (sqlService.CreateCase(ccasees) > 0)

		    {
			  ClearFileds();
		    }
		}


	  }





	  private void ClearFileds()
	  {
		
		tbtitle.Text = "";
		tbdatecreated.Text = "";
		tbdescription.Text = "";
		tbDatechanged.Text = "";
		cbStatus.Text = "";



	  }

	  //  private void PopulateStatus()
	  //  {
	  //	cbStatus.Items.Clear();
	  //	foreach (var status in sqlService.GetStatus())
	  //	    cbStatus.Items.Add(new KeyValuePair<int, string>());

	  // }
	  //  private void PopulateStatus()
	  // {
	  //	IEnumerable<int> enumerable = Enumerable.Range(1, 300);
	  //foreach (var status in Enum.GetValues(typeof(sta)))
	  //foreach (var status in List.get)
	  //	{
	  //cbStatus.Items.Add(new KeyValuePair<int, string>((int)status, status.ToString()));
	  //}
	  //  }
	  private void PopulateStatus()
	  {
		cbStatus.Items.Clear();
		foreach (var status in Enum.GetValues(typeof(Statuses)))
		{
		    cbStatus.Items.Add(new KeyValuePair<int, string>((int)status, status.ToString()));
		}
	  }

	  private void cbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
	  {
		
		
		
	  }
	 
    }





}

     

		


	  

