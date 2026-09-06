using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Core;

[Table("views")]
partial class View
{
    private int _id;

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

    [Column("model")]
    public required int ModelId
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
}
