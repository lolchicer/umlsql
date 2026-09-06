using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Functional;

[Table("arguments")]
public partial class Argument
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
}
