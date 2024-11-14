using System;
using System.Windows;
using System.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using ZplManager.Views;
using ZplManager.SupportMethods;
using ZplManager.Models;

namespace ZplManager.ViewModels;

public class MatrixCode : INotifyPropertyChanged
{
    //private CodeManager my_label;
    
    public MatrixCode()
    {
        //my_label = new CodeManager();

        ICButton_clear = new RelayCommand(clear);
        ICButton_write = new RelayCommand(write);

    }

    #region COMMANDs
    // This commands are binding into XAML code
    public ICommand ICButton_clear {get; private set;}
    public ICommand ICButton_write {get; private set;}
    public ICommand  SaveCommand {get; private set;}

    // Methode for Commands
    public void clear(object parm)
    {
        MessageBox.Show("Clear");
    }
    public void write(object parm)
    {
        MessageBox.Show("Write");
    }

    //  This command is binding into XAML but but not directly
    public void save()
    {
        MessageBox.Show("Save...");
    }
    #endregion


    #region  INPCh
    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

}
