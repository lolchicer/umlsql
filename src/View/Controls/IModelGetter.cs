namespace Lolchicer.Umlsql.View.Controls;

public interface IModelGetter<T> where T : ViewModel.Core.IModel
{
    public T Model { get; }
}
