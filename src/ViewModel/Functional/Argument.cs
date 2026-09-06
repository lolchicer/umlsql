using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Argument
    : INotifyPropertyChanged, IArgument
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Function _function;

    private Function _type;

    public required Function Function
    {
        get => _function;
        set
        {
            _function = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    public required Function Type
    {
        get => _type;
        set
        {
            _type = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    public IEnumerable<Method> Methods { get; } = [];

    IFunction IArgument.Function => Function;
    IFunction IArgument.Type => Type;
}
