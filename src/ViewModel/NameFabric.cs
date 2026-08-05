namespace Lolchicer.Umlsql.ViewModel;

public interface INameFabric<T> where T : IRow
{
    public string Name(T t);
}

public static class NameFabrication
{
    public static string Name<T>(this T t, INameFabric<T> nameFabric)
        where T : IRow =>
        nameFabric.Name(t);
}

public class ApplicationNameFabric :
INameFabric<Model>,
INameFabric<View>,
INameFabric<Function>,
INameFabric<Argument>,
INameFabric<Interface>,
INameFabric<Method>,
INameFabric<Getproperty>,
INameFabric<Setproperty>
{
    string INameFabric<Model>.Name(Model t) =>
    string.Concat("m", t.Id.ToString());

    string INameFabric<View>.Name(View t) =>
    string.Concat("v", t.Id.ToString(), "m", t.ModelId.ToString());

    string INameFabric<Function>.Name(Function t) =>
    string.Concat("f", t.Id.ToString());
    
    string INameFabric<Argument>.Name(Argument t) =>
    string.Concat("f", t.Id.ToString(), "a");
    
    string INameFabric<Interface>.Name(Interface t) =>
    string.Concat("f", t.Id.ToString(), "i");
    
    string INameFabric<Method>.Name(Method t) =>
    string.Concat("f", t.Id.ToString(), "m");
    
    string INameFabric<Setproperty>.Name(Setproperty t) =>
    string.Concat("f", t.Id.ToString(), "sp");
    
    string INameFabric<Getproperty>.Name(Getproperty t) =>
    string.Concat("f", t.Id.ToString(), "gp");
}
