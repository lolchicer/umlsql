using System.ComponentModel;

namespace Lolchicer.Umlsql.ViewModel.Documentational;

public partial class Document
    : INotifyPropertyChanged, IDocument
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public required Core.Model Model { get; set; }
    public Core.Model AdditionalTermsType { get; set; }
    public Core.Model ViewsType { get; set; }
    public Core.Model NameType { get; set; }
    public Core.Model LinksType { get; set; }
    public Core.Model DateType { get; set; }
    public Core.Model DocumentType { get; set; }

    Core.IModel IDocument.Model => Model;
    Core.IModel IDocument.AdditionalTermsType => AdditionalTermsType;
    Core.IModel IDocument.ViewsType => ViewsType;
    Core.IModel IDocument.NameType => NameType;
    Core.IModel IDocument.LinksType => LinksType;
    Core.IModel IDocument.DateType => DateType;
    Core.IModel IDocument.DocumentType => DocumentType;
}
