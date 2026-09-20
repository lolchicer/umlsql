namespace Lolchicer.Umlsql.Model.Documentational;

public interface IDocument :
    Descriptional.IAdditionalTermsParagraph,
    Descriptional.IViewsParagraph,
    Descriptional.INameParagraph,
    Descriptional.ILinksParagraph,
    Descriptional.IDateParagraph
{
    public new Core.IModel Model { get; }
    public Core.IModel AdditionalTermsType { get; }
    public Core.IModel ViewsType { get; }
    public Core.IModel NameType { get; }
    public Core.IModel LinksType { get; }
    public Core.IModel DateType { get; }
    public Core.IModel DocumentType { get; }


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
}
