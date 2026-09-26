using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Iterational;

public partial class Redaction
    : INotifyPropertyChanged, IRedaction
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public required Core.Model Model { get; set; }
    public Core.Model Type { get; set; }

    Core.IModel IRedaction.Model => Model;
    Core.IModel IRedaction.Type => Model;
}
