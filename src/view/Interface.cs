using System;
using System.ComponentModel;

namespace Lolchicer.Umlsql.View;

public class Interface : IInterface, INotifyPropertyChanged
{
    private string _name;

    public event PropertyChangedEventHandler? PropertyChanged;

    public required string Name
    {
        get => _name;
        set
        {
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }
}
