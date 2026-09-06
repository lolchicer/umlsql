using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Core;

public partial class View
    : INotifyPropertyChanged, IView
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Model _model;

    private Model _type;

    public required Model Model
    {
        get => _model;
        set
        {
            _model = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Model)));
        }
    }

    public required Model Type
    {
        get => _type;
        set
        {
            _type = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Type)));
        }
    }

    IModel IView.Model => Model;
    IModel IView.Type => Type;
}
