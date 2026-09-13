using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Function
    : INotifyPropertyChanged, IFunction
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public IList<Argument> Arguments { get; } = [];
    public IList<Argument> ArgumentTypes { get; } = [];
    public IList<Interface> Interfaces { get; } = [];
}
