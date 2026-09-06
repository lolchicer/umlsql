using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Functional;

[Table("methods")]
public partial class Method
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
