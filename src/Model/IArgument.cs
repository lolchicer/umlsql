using Lolchicer.Umlsql.View;

namespace Lolchicer.Umlsql.Model;

interface IArgument
{
    public ISetproperty Setproperty { get; }
    public IInterface Type { get; }
}
