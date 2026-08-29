using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Core;

[Table("views")]
public class View : IView, ISettableRow, INotifyPropertyChanged
{
    private int _id;

    private Model _model;

    private Model _type;

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

    public required int ModelId
    {
        get;
        set;
    }

    public required int TypeId
    {
        get;
        set;
    }

    public required Model Model
    {
        get => _model;
        set
        {
            _model = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Model)));
        }
    }

    public required Model Type
    {
        get => _type;
        set
        {
            _type = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Type)));
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

    IModel IView.Model => Model;
    IModel IView.Type => Type;
}
