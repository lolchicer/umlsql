using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Functional;

[Table("interfaces")]
public partial class Interface
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
}
