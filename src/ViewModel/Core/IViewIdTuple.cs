namespace Lolchicer.Umlsql.ViewModel.Core;

public interface IViewIdTuple
    : IIdTuple<View>, IModelIdTuple
{
    public new int Id { get; }
    public int ModelId { get; }

    public new View GetModel(
        IEnumerable<View> views) =>
        views.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);

    View IIdTuple<View>.GetModel(IEnumerable<View> views) => GetModel(views);

    int IModelIdTuple.Id => Id;
}

public readonly struct ViewIdTuple
    : IViewIdTuple
{
    public readonly int Id;
    public readonly int ModelId;

    int IViewIdTuple.Id => Id;
    int IViewIdTuple.ModelId => ModelId;
}
