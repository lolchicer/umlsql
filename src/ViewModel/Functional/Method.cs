using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Method
    : INotifyPropertyChanged, Model.Functional.IMethod
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Argument _argument;

    public required Argument Argument
    {
        get => _argument;
        set
        {
            _argument = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    public IEnumerable<Getproperty> Getproperties { get; } = [];
    public IEnumerable<Setproperty> Setproperties { get; } = [];

    Model.Functional.IArgument Model.Functional.IMethod.Argument => Argument;
}
