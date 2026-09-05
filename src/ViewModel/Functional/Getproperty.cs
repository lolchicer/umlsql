using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel.Functional;

[Table("getproperties")]
public class Getproperty : Model.Functional.IGetproperty, INotifyPropertyChanged
{
    private int _id;

    private Method _method;

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

    [Column("method")]
    public required int MethodId
    {
        get;
        set;
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

    public required Method Method
    {
        get => _method;
        set
        {
            _method = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    Model.Functional.IMethod Model.Functional.IGetproperty.Method => Method;
}
