namespace Lolchicer.Umlsql.ViewModel.Documentational;

public interface INewDocumentIdTuple
    : IDocumentIdTuple
{
    public int AdditionalTermsTypeId { get; }
    public int ViewsTypeId { get;}
    public int NameTypeId { get;}
    public int LinksTypeId { get; }
    public int DateTypeId { get; }
    public int DocumentTypeId { get; }

    public new Document GetModel(
        IEnumerable<Document> documents) =>
        documents.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId &&
            model.AdditionalTermsTypeId == AdditionalTermsTypeId &&
            model.ViewsTypeId == ViewsTypeId &&
            model.NameTypeId == NameTypeId &&
            model.LinksTypeId == LinksTypeId &&
            model.DateTypeId == DateTypeId &&
            model.DocumentTypeId == DocumentTypeId);

    Document IIdTuple<Document>.GetModel(IEnumerable<Document> documents) => GetModel(documents);
}

public readonly struct NewDocumentIdTuple
    : INewDocumentIdTuple
{
    public readonly int Id;
    public readonly int ModelId;
    public readonly int AdditionalTermsTypeId;
    public readonly int ViewsTypeId;
    public readonly int NameTypeId;
    public readonly int LinksTypeId;
    public readonly int DateTypeId;
    public readonly int DocumentTypeId;

    int IDocumentIdTuple.Id => Id;
    int IDocumentIdTuple.ModelId => ModelId;
    int INewDocumentIdTuple.AdditionalTermsTypeId => AdditionalTermsTypeId;
    int INewDocumentIdTuple.ViewsTypeId => ViewsTypeId;
    int INewDocumentIdTuple.NameTypeId => NameTypeId;
    int INewDocumentIdTuple.LinksTypeId => LinksTypeId;
    int INewDocumentIdTuple.DateTypeId => DateTypeId;
    int INewDocumentIdTuple.DocumentTypeId => DocumentTypeId;
}
