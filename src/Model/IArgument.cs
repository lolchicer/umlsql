namespace Lolchicer.Umlsql.Model;

interface IArgument
{
    public IFunction Function { get; }
    public IFunction Type { get; }
}
