using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel;

[Table("interfaces")]
public class Interface : IInterface, ISettableRow, INotifyPropertyChanged
{
    private int _id;

    private Function _function;

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

    [Column("function")]
    public required int FunctionId
    {
        get;
        set;
    }

    public required Function Function
    {
        get => _function;
        set
        {
            _function = value;
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

    IFunction IInterface.Function => Function;
}
