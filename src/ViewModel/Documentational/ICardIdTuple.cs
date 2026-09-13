namespace Lolchicer.Umlsql.ViewModel.Documentational;

public interface ICardIdTuple
    : IIdTuple<Card>, Core.IModelIdTuple
{
    public new int Id { get; }
    public int ModelId { get; }

    public new Card GetModel(
        IEnumerable<Card> cards) =>
        cards.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);

    Card IIdTuple<Card>.GetModel(
        IEnumerable<Card> models) =>
        GetModel(models);

    int Core.IModelIdTuple.Id => Id;
}

public readonly struct CardIdTuple
    : ICardIdTuple
{
    public readonly int Id;
    public readonly int ModelId;

    int ICardIdTuple.Id => Id;
    int ICardIdTuple.ModelId => ModelId;
}
