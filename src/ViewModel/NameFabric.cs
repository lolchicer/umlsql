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
INameFabric<Core.Model>,
INameFabric<Core.View>,
INameFabric<Functional.Function>,
INameFabric<Functional.Argument>,
INameFabric<Functional.Interface>,
INameFabric<Functional.Method>,
INameFabric<Functional.Getproperty>,
INameFabric<Functional.Setproperty>
{
    string INameFabric<Core.Model>.Name(Core.Model t) =>
    string.Concat("m", t.Id.ToString());

    string INameFabric<Core.View>.Name(Core.View t) =>
    string.Concat("v", t.Id.ToString(), "m", t.ModelId.ToString());

    string INameFabric<Functional.Function>.Name(Functional.Function t) =>
    string.Concat("f", t.Id.ToString());
    
    string INameFabric<Functional.Argument>.Name(Functional.Argument t) =>
    string.Concat("f", t.Id.ToString(), "a");
    
    string INameFabric<Functional.Interface>.Name(Functional.Interface t) =>
    string.Concat("f", t.Id.ToString(), "i");
    
    string INameFabric<Functional.Method>.Name(Functional.Method t) =>
    string.Concat("f", t.Id.ToString(), "m");
    
    string INameFabric<Functional.Setproperty>.Name(Functional.Setproperty t) =>
    string.Concat("f", t.Id.ToString(), "sp");
    
    string INameFabric<Functional.Getproperty>.Name(Functional.Getproperty t) =>
    string.Concat("f", t.Id.ToString(), "gp");
}
