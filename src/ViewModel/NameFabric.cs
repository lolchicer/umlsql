using Lolchicer.Umlsql.Model.Documentational;

namespace Lolchicer.Umlsql.ViewModel;

public interface INameFabric<T> where T : ICard
{
    public string Name(T t);
}

public class ApplicationNameFabric :
INameFabric<Documentational.Card>
{
    string INameFabric<Documentational.Card>.Name(Documentational.Card t) =>
    string.Concat("m", t.Id.ToString());
}
