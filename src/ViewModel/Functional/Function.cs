using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Function
    : INotifyPropertyChanged, Model.Functional.IFunction
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public IEnumerable<Argument> Arguments { get; } = [];
    public IEnumerable<Argument> ArgumentTypes { get; } = [];
    public IEnumerable<Interface> Interfaces { get; } = [];
}
