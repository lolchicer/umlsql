namespace Lolchicer.Umlsql.View;

public interface IModelGetter<T> where T : ViewModel.Core.IModel
{
    public T Model { get; }
}
