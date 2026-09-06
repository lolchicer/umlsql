using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Setproperty
    : INotifyPropertyChanged, Model.Functional.ISetproperty
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Method _method;

    public required Method Method
    {
        get => _method;
        set
        {
            _method = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    Model.Functional.IMethod Model.Functional.ISetproperty.Method => Method;
}
