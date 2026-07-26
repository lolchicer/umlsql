namespace Lolchicer.Umlsql.ViewModel;

public interface INameFabric<T> where T : IRow
{
    public string Name(T t);
}

public class ApplicationNameFabric :
INameFabric<Function>,
INameFabric<Argument>,
INameFabric<Interface>,
INameFabric<Method>,
INameFabric<Getproperty>,
INameFabric<Setproperty>
{
    string INameFabric<Function>.Name(Function t) =>
    string.Format("f", t.Id.ToString());
    
    string INameFabric<Argument>.Name(Argument t) =>
    string.Format("f", t.Id.ToString(), "a");
    
    string INameFabric<Interface>.Name(Interface t) =>
    string.Format("f", t.Id.ToString(), "i");
    
    string INameFabric<Method>.Name(Method t) =>
    string.Format("f", t.Id.ToString(), "m");
    
    string INameFabric<Setproperty>.Name(Setproperty t) =>
    string.Format("f", t.Id.ToString(), "sp");
    
    string INameFabric<Getproperty>.Name(Getproperty t) =>
    string.Format("f", t.Id.ToString(), "gp");
}
