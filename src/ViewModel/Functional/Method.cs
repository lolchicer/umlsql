using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Method : Model.Functional.IMethod, INotifyPropertyChanged
{
    private Argument _argument;

    public event PropertyChangedEventHandler? PropertyChanged;

    public required Argument Argument
    {
        get => _argument;
        set
        {
            _argument = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    public IEnumerable<Getproperty> Getproperties { get; } = [];
    public IEnumerable<Setproperty> Setproperties { get; } = [];

    Model.Functional.IArgument Model.Functional.IMethod.Argument => Argument;
}
