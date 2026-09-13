namespace Lolchicer.Umlsql.ViewModel.Core;

public interface IModelIdTuple
    : IIdTuple<Model>
{
    public int Id { get; }

    public new Model GetModel(
        IEnumerable<Model> models) =>
        models.First(
            model =>
            model.Id == Id);

    Model IIdTuple<Model>.GetModel(
        IEnumerable<Model> models) =>
        GetModel(models);
}

public readonly struct ModelIdTuple
    : IModelIdTuple
{
    public readonly int Id;

    int IModelIdTuple.Id => Id;
}
