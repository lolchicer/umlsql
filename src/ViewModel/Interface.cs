using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel;

[Table("interfaces")]
public class Interface : IInterface, INotifyPropertyChanged
{
    private int _id;

    private Function _type;

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

    [Column("type")]
    public required int TypeId
    {
        get;
        set;
    }

    public required Function Type
    {
        get => _type;
        set
        {
            _type = value;
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

    public IEnumerable<Method> Methods { get; } = [];
    public IEnumerable<Argument> Arguments { get; } = [];
    public IEnumerable<Getproperty> Getproperties { get; } = [];

    IFunction IInterface.Type => Type;
}
