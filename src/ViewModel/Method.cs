using Lolchicer.Umlsql.Model;
using Lolchicer.Umlsql.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel;

[Table("methods")]
[PrimaryKey("Id", "Interface")]
public class Method : IMethod, INotifyPropertyChanged
{
    private int _id;

    private Interface _interface;

    private string _name = "";

    public event PropertyChangedEventHandler? PropertyChanged;

    [Key]
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

    [Key]
    [ForeignKey("interface")]
    public Interface Interface
    {
        get => _interface;
        set
        {
            _interface = value;
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

    IInterface IMethod.Interface => Interface;
}
