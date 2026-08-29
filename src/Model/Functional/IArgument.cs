namespace Lolchicer.Umlsql.Model;

public interface IArgument
{
    public IFunction Function { get; }
    public IFunction Type { get; }
}
