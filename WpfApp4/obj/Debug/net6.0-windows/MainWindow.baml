   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	   E'clr-namespace:WpfApp4.Models.ViewModelsWpfApp4.Models.ViewModels  5   	       WpfApp4.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	   =	viewModel'clr-namespace:WpfApp4.Models.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      3  -WpfApp4.Models.ViewModels.MainWindowViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   ��6)   �� *CurrentView+�� 5   
   $��0��6   ���#f6f6f6.+�5      	� $��	Customers��6   $��7q�6.    d� 	IsChecked$
 TrueY�6;   $
��Left=�6L      MenuItemTemplate#��[  6n   ��6�   �� *CustomerViewCommand+	� 5      $��New Customers��6   $��7q�63   $
��Left=�6?   #��[  6b   ��6�   �� *CreateCustomerViewCommand+	� 5      $
��Case��6   $��7q�6*   $
��Left=�67   #��[  6Z   ��6�   �� *CaseViewCommand+	� 5      $��New case��6   $��7q�6.   $
��Left=�6:   #��[  6]   ��6�   �� *CreateCaseViewCommand+5      5      5      