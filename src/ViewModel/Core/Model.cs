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
    public IList<Iterational.Redaction> Redactions { get; } = [];
    public IList<Iterational.Redaction> RedactionTypes { get; } = [];
    public IList<Documentational.Document> Documents { get; } = [];
    public IList<Documentational.Document> DocumentTypes { get; } = [];
    public IList<Documentational.Document> AdditionalTermsTypes { get; } = [];
    public IList<Documentational.Document> ViewsTypes { get; } = [];
    public IList<Documentational.Document> NameTypes { get; } = [];
    public IList<Documentational.Document> LinksTypes { get; } = [];
    public IList<Documentational.Document> DateTypes { get; } = [];
}
