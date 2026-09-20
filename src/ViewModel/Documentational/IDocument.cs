namespace Lolchicer.Umlsql.ViewModel.Documentational;

public interface IDocument :
    Descriptional.IAdditionalTermsParagraph,
    Descriptional.IViewsParagraph,
    Descriptional.INameParagraph,
    Descriptional.ILinksParagraph,
    Descriptional.IDateParagraph,
    Model.Documentational.IDocument
{
    public new Core.IModel Model { get; }
    public new Core.IModel AdditionalTermsType { get; }
    public new Core.IModel ViewsType { get; }
    public new Core.IModel NameType { get; }
    public new Core.IModel LinksType { get; }
    public new Core.IModel DateType { get; }
    public new Core.IModel DocumentType { get; }

    Core.IModel
        Descriptional.IAdditionalTermsParagraph.Model => Model;
    Core.IModel
        Descriptional.IAdditionalTermsParagraph.Type => AdditionalTermsType;

    Core.IModel
        Descriptional.IViewsParagraph.Model => Model;
    Core.IModel
        Descriptional.IViewsParagraph.Type => ViewsType;

    Core.IModel
        Descriptional.INameParagraph.Model => Model;
    Core.IModel
        Descriptional.INameParagraph.Type => NameType;

    Core.IModel
        Descriptional.ILinksParagraph.Model => Model;
    Core.IModel
        Descriptional.ILinksParagraph.Type => LinksType;

    Core.IModel
        Descriptional.IDateParagraph.Model => Model;
    Core.IModel
        Descriptional.IDateParagraph.Type => DateType;

    Core.IModel
        Descriptional.IParagraph.Model => Model;
    Core.IModel
        Descriptional.IParagraph.Type => DocumentType;

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => DocumentType;

    Model.Core.IModel
        Model.Documentational.IDocument.Model => Model;
    Model.Core.IModel
        Model.Documentational.IDocument.AdditionalTermsType => AdditionalTermsType;
    Model.Core.IModel
        Model.Documentational.IDocument.ViewsType => ViewsType;
    Model.Core.IModel
        Model.Documentational.IDocument.NameType => NameType;
    Model.Core.IModel
        Model.Documentational.IDocument.LinksType => LinksType;
    Model.Core.IModel
        Model.Documentational.IDocument.DateType => DateType;
    Model.Core.IModel
        Model.Documentational.IDocument.DocumentType => DocumentType;

    Model.Core.IModel
        Model.Descriptional.IAdditionalTermsParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.IAdditionalTermsParagraph.Type => AdditionalTermsType;

    Model.Core.IModel
        Model.Descriptional.IViewsParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.IViewsParagraph.Type => ViewsType;

    Model.Core.IModel
        Model.Descriptional.INameParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.INameParagraph.Type => NameType;

    Model.Core.IModel
        Model.Descriptional.ILinksParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.ILinksParagraph.Type => LinksType;

    Model.Core.IModel
        Model.Descriptional.IDateParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.IDateParagraph.Type => DateType;

    Model.Core.IModel
        Model.Descriptional.IParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.IParagraph.Type => DocumentType;

    Model.Core.IModel
        Model.Core.IView.Model => Model;
    Model.Core.IModel
        Model.Core.IView.Type => DocumentType;
}
