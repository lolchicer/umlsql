namespace Lolchicer.Umlsql.View.Controls;

public interface IModelGetterAsync<T> where T : ViewModel.Core.IModel
{
    public Task<T> GetModel();
}
