using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Functional;

[Table("setproperties")]
public partial class Setproperty
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
}
