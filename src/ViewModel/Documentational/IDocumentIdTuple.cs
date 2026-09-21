namespace Lolchicer.Umlsql.ViewModel.Documentational;

public interface IDocumentIdTuple
    : IIdTuple<Document>, Core.IViewIdTuple
{
    public new int Id { get; }
    public new int ModelId { get; }

    public new Document GetModel(
        IEnumerable<Document> documents) =>
        documents.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);

    Document IIdTuple<Document>.GetModel(IEnumerable<Document> documents) => GetModel(documents);

    int Core.IViewIdTuple.Id => Id;
    int Core.IViewIdTuple.ModelId => Id;
}

public readonly struct DocumentIdTuple
    : IDocumentIdTuple
{
    public readonly int Id;
    public readonly int ModelId;

    int IDocumentIdTuple.Id => Id;
    int IDocumentIdTuple.ModelId => ModelId;
}
