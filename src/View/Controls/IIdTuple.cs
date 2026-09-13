namespace Lolchicer.Umlsql.View.Controls;

public interface IIdTuple<T> where T : ViewModel.Core.IModel
{
    public T GetModel(IEnumerable<T> models);
}

public interface IModelGetter<T1, T2>
    where T1 : ViewModel.Core.IModel
{
    T1 GetModel(IEnumerable<T1> t1s, T2 t2);
}
