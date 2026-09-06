using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Getproperty
    : INotifyPropertyChanged, Model.Functional.IGetproperty
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

    Model.Functional.IMethod Model.Functional.IGetproperty.Method => Method;
}
