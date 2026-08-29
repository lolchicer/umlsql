namespace Lolchicer.Umlsql.Model.Functional;

public interface IArgument
{
    public IFunction Function { get; }
    public IFunction Type { get; }
}
