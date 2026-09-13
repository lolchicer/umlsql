namespace Lolchicer.Umlsql.ViewModel;

public interface IModelGetter<T> where T : Core.IModel
{
    public T Model { get; }
}
