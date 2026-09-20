using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Iterational;

[Table("recations")]
public partial class Redaction
{
    private int _id;

    [Column("id")]
    public int Id
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
