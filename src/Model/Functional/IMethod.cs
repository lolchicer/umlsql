namespace Lolchicer.Umlsql.Model.Functional;

public interface IMethod : Core.IModel
{
    public IArgument Argument { get; }
}
