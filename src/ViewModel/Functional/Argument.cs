using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel.Functional;

[Table("arguments")]
public class Argument : Model.Functional.IArgument, INotifyPropertyChanged
{
    private int _id;

    private Function _function;

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

    [Column("function")]
    public required int FunctionId
    {
        get;
        set;
    }

    [Column("type")]
    public required int TypeId
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

    public required Function Type
    {
        get => _type;
        set
        {
            _type = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    public IEnumerable<Method> Methods { get; } = [];

    Model.Functional.IFunction Model.Functional.IArgument.Function => Function;
    Model.Functional.IFunction Model.Functional.IArgument.Type => Type;
}
