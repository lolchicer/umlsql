using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Core;

public partial class Model
    : INotifyPropertyChanged, Automatons.Core.IModel
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void Approve(Model model, Model type)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<View> Views { get; } = [];
    public IEnumerable<View> ViewTypes { get; } = [];
    public IEnumerable<Documentational.Card> Cards { get; } = [];
}
