namespace Lolchicer.Umlsql.ViewModel.Core;

public interface INewViewIdTuple
    : IViewIdTuple
{
    public int TypeId { get; }

    public new View GetModel(
        IEnumerable<View> views) =>
        views.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId &&
            model.TypeId == TypeId);

    View IIdTuple<View>.GetModel(IEnumerable<View> views) => GetModel(views);
}

public readonly struct NewViewIdTuple
    : INewViewIdTuple
{
    public readonly int Id;
    public readonly int ModelId;
    public readonly int TypeId;

    int IViewIdTuple.Id => Id;
    int IViewIdTuple.ModelId => ModelId;
    int INewViewIdTuple.TypeId => TypeId;
}
