using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace ZplManager.ViewModels;

public partial class Print: ObservableObject
{
    [ObservableProperty]
    private string message = "Welcome to MVVM without Code-Behind!";
    public Print(){}

    [RelayCommand]
    public void Save()
    {
        MessageBox.Show("xxx");
    }

}
