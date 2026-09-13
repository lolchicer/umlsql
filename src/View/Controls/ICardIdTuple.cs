namespace Lolchicer.Umlsql.View.Controls;

public interface ICardIdTuple
    : IIdTuple<ViewModel.Documentational.Card>
{
    public int Id { get; }
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
}

public readonly struct CardIdTuple
    : ICardIdTuple
{
    public readonly int Id;
    public readonly int ModelId;

    int ICardIdTuple.Id => Id;
    int ICardIdTuple.ModelId => ModelId;
}
