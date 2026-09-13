namespace Lolchicer.Umlsql.ViewModel;

public interface IIdTuple<T> where T : Core.IModel
{
    public T GetModel(IEnumerable<T> models);
}

public interface IModelGetter<T1, T2>
    where T1 : Core.IModel
{
    T1 GetModel(IEnumerable<T1> t1s, T2 t2);
}
