namespace Lolchicer.Umlsql.Model.Functional;

public interface IArgument : Core.IModel
{
    public IFunction Function { get; }
    public IFunction Type { get; }
}
