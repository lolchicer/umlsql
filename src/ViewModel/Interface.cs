using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel;

[Table("objects")]
public class Interface : IInterface, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    [Column("id")]
    public required int Id { get; set; }
}
