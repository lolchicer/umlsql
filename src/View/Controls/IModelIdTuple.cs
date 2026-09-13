namespace Lolchicer.Umlsql.View.Controls;

public interface IModelIdTuple
    : IIdTuple<ViewModel.Core.Model>
{
    public int Id { get; }

    public new ViewModel.Core.Model GetModel(
        IEnumerable<ViewModel.Core.Model> models) =>
        models.First(
            model =>
            model.Id == Id);

    ViewModel.Core.Model IIdTuple<ViewModel.Core.Model>.GetModel(
        IEnumerable<ViewModel.Core.Model> models) =>
        GetModel(models);
}

public readonly struct ModelIdTuple
    : IModelIdTuple
{
    public readonly int Id;

    int IModelIdTuple.Id => Id;
}
