namespace Lolchicer.Umlsql.ViewModel.Iterational;

public interface INewRedactionIdTuple
    : IRedactionIdTuple
{
    public int TypeId { get; }

    public new Redaction GetModel(
        IEnumerable<Redaction> redactions) =>
        redactions.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId &&
            model.TypeId == TypeId);

    Redaction IIdTuple<Redaction>.GetModel(IEnumerable<Redaction> redactions) => GetModel(redactions);
}

public readonly struct NewRedactionIdTuple
    : INewRedactionIdTuple
{
    public readonly int Id;
    public readonly int ModelId;
    public readonly int TypeId;

    int IRedactionIdTuple.Id => Id;
    int IRedactionIdTuple.ModelId => ModelId;
    int INewRedactionIdTuple.TypeId => TypeId;
}
