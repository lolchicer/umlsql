namespace Lolchicer.Umlsql.ViewModel;

public interface INameFabric<T> where T : Model.Core.IModel
{
    public string Name(T t);
}
