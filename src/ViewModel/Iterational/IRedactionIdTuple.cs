namespace Lolchicer.Umlsql.ViewModel.Iterational;

public interface IRedactionIdTuple
    : IIdTuple<Redaction>, Core.IViewIdTuple
{
    public new int Id { get; }
    public new int ModelId { get; }

    public new Redaction GetModel(
        IEnumerable<Redaction> redactions) =>
        redactions.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);

    Redaction IIdTuple<Redaction>.GetModel(IEnumerable<Redaction> redactions) => GetModel(redactions);

    int Core.IViewIdTuple.Id => Id;
    int Core.IViewIdTuple.ModelId => Id;
}

public readonly struct RedactionIdTuple
    : IRedactionIdTuple
{
    public readonly int Id;
    public readonly int ModelId;

    int IRedactionIdTuple.Id => Id;
    int IRedactionIdTuple.ModelId => ModelId;
}
