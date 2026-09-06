using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Interface : Model.Functional.IInterface, INotifyPropertyChanged
{
    private Function _function;

    public event PropertyChangedEventHandler? PropertyChanged;

    public required Function Function
    {
        get => _function;
        set
        {
            _function = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    Model.Functional.IFunction Model.Functional.IInterface.Function => Function;
}
