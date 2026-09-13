namespace Lolchicer.Umlsql.View.Controls;

public interface IViewIdTuple
    : IIdTuple<ViewModel.Core.View>, IModelIdTuple
{
    public int Id { get; }
    public int ModelId { get; }

    public new ViewModel.Core.View GetModel(
        IEnumerable<ViewModel.Core.View> views) =>
        views.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);

    ViewModel.Core.View IIdTuple<ViewModel.Core.View>.GetModel(IEnumerable<ViewModel.Core.View> views) => GetModel(views);

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
