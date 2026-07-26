using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel;

[Table("methods")]
public class Method : IMethod, INotifyPropertyChanged
{
    private int _id;

    private Argument _argument;

    private string _name = "";

    public event PropertyChangedEventHandler? PropertyChanged;

    [Column("id")]
    public required int Id
    {
        get => _id;
        set
        {
            _id = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    [Column("argument")]
    public required int ArgumentId
    {
        get;
        set;
    }

    [Column("function")]
    public required int FunctionId
    {
        get;
        set;
    }

    public required Argument Argument
    {
        get => _argument;
        set
        {
            _argument = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    [NotMapped]
    public required string Name
    {
        get => _name;
        set
        {
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    public IEnumerable<Getproperty> Getproperties { get; } = [];
    public IEnumerable<Setproperty> Setproperties { get; } = [];

    IArgument IMethod.Argument => Argument;
}
