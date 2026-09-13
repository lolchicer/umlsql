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

    public IList<View> Views { get; } = [];
    public IList<View> ViewTypes { get; } = [];
    public IList<Documentational.Card> Cards { get; } = [];
}
