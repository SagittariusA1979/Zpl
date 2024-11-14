using System;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Text;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;


namespace ZplManager.Models;

public class MatrixCodeModel : INotifyPropertyChanged
{
    public MatrixCodeModel()
    {
        
    }

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
