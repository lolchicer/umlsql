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
}
