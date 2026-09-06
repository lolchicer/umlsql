using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Functional;

public partial class Getproperty
    : INotifyPropertyChanged, IGetproperty
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

    IMethod IGetproperty.Method => Method;
}
