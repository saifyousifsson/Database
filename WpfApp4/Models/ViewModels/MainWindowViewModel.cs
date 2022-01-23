using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Helpers;

namespace WpfApp4.Models.ViewModels
{
    internal class MainWindowViewModel: ObservableObject
    {
	  private object _currentView;

	  public RelayCommand CustomerViewCommand { get; set; }
	  public RelayCommand CreateCustomerViewCommand { get; set; }
	  public RelayCommand CaseViewCommand { get; set; }
	  public RelayCommand CreateCaseViewCommand { get; set; }
	  public CustomerViewModel CustomerViewModel { get; set; }
	  public RelayCommand CreatCustomerViewCommand { get; set; }
	  public CreateCaseViewModel CreateCaseViewModel { get; set; }
	  public CreateCustomerViewModel CreateCustomerViewModel { get; set; }
	  public RelayCommand CaseViewModelCommand { get; set; }
	  public CaseViewModel CaseViewModel { get; set; }
	  public RelayCommand CustomerViewModelCommand { get; set; }
	  public Object CurrentView
	  {
		get { return _currentView; }
		set
		{
		    _currentView = value;
		    OnPropertyChanged();
		}
	  }
	  public MainWindowViewModel()
	  {
		CustomerViewModel = new CustomerViewModel();
		CreateCustomerViewModel = new CreateCustomerViewModel();
		CreateCaseViewModel = new CreateCaseViewModel();
		//CaseViewModel = new CaseViewModel();
		CaseViewModel = new CaseViewModel();
		CustomerViewModel = new CustomerViewModel();
		//CaseViewModel=new CaseViewModel();
		CurrentView = CustomerViewModel;
		CustomerViewCommand = new RelayCommand(x => CurrentView = CustomerViewModel);
		CaseViewCommand = new RelayCommand(x => CurrentView = CaseViewModel);
		CreateCustomerViewCommand = new RelayCommand(x => CurrentView = CreateCustomerViewModel);
		CreateCaseViewCommand = new RelayCommand(x => CurrentView = CreateCaseViewModel);

	  }
    }
}
