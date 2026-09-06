using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Interface
    : INotifyPropertyChanged, Model.Functional.IInterface
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Function _function;

    public required Function Function
    {
        get => _function;
        set
        {
            _function = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    Model.Functional.IFunction Model.Functional.IInterface.Function => Function;
}
