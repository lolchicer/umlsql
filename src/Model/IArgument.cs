using Lolchicer.Umlsql.View;

namespace Lolchicer.Umlsql.Model;

interface IArgument
{
    public IMethod Method { get; }
    public IInterface Type { get; }
}
