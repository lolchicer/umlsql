using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Core;

[Table("models")]
public class Model : Automatons.Core.IModel, INotifyPropertyChanged
{
    private int _id;

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

    public void Approve(Model model, Model type)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<View> Views { get; } = [];
    public IEnumerable<View> ViewTypes { get; } = [];
    public IEnumerable<Documentational.Card> Cards { get; } = [];
}
