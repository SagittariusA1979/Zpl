using System;
using System.Windows;
using System.ComponentModel;
using System.Windows.Input;
using ZplManager.Views;
using ZplManager.SupportMethods;


namespace ZplManager.ViewModels;

public class NavigatorViewModel: INotifyPropertyChanged
{
    #region INSTANCE
    private static NavigatorViewModel _instanceNav;
    #endregion

    
    public NavigatorViewModel()
    {
        ICitem01 = new RelayCommand(item01);
        ICitem02 = new RelayCommand(item02);
        ICitem03 = new RelayCommand(item03);
        ICitem04 = new RelayCommand(item04);

        SelectViewModel = new StartView(); 
    }

    #region SINGELTON
    public NavigatorViewModel InstanceNav
    {
        get
        {
            if(_instanceNav == null)
            {
               _instanceNav = new NavigatorViewModel();
            }
            return _instanceNav;
        }
    }
    #endregion
    
    #region SELECTViewModel
    private object _selectViewModel;
    public object SelectViewModel
    {
        get{ return _selectViewModel; }
        set
        {
            _selectViewModel = value;
            OnPropertyChanged(nameof(SelectViewModel));
        }
    }
    #endregion

    #region COMMANDs
    public ICommand ICitem01 {get; private set;}
    public ICommand ICitem02 {get; private set;}
    public ICommand ICitem03 {get; private set;}
    public ICommand ICitem04 {get; private set;}
    
    // Methods for Command
    public void item01(object parm) // Print the labels
    {   
        SelectViewModel = new PrintView();
        MessageBox.Show("Printing");
    }
    public void item02(object parm) // Preparing the labels
    {
        SelectViewModel = new MatrixCodeView();  // new object();
        MessageBox.Show("Preparing");
    }
    public void item03(object parm) // Setting of connect whit periphery
    {
        SelectViewModel = new SettingView();
        MessageBox.Show("Setting");
    }
    public void item04(object parm) // Quit from App
    {
        SelectViewModel = new object();
        MessageBox.Show("EXIT");
    }

    #endregion


    #region INPCh
    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        if(PropertyChanged != null)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion

}
