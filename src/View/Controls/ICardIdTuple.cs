namespace Lolchicer.Umlsql.View.Controls;

public interface ICardIdTuple
    : IIdTuple<ViewModel.Documentational.Card>, IModelIdTuple
{
    public new int Id { get; }
    public int ModelId { get; }

    public new ViewModel.Documentational.Card GetModel(
        IEnumerable<ViewModel.Documentational.Card> cards) =>
        cards.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);

    ViewModel.Documentational.Card IIdTuple<ViewModel.Documentational.Card>.GetModel(
        IEnumerable<ViewModel.Documentational.Card> models) =>
        GetModel(models);

    int IModelIdTuple.Id => Id;
}

public readonly struct CardIdTuple
    : ICardIdTuple
{
    public readonly int Id;
    public readonly int ModelId;

    int ICardIdTuple.Id => Id;
    int ICardIdTuple.ModelId => ModelId;
}
