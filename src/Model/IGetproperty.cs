using Lolchicer.Umlsql.View;

namespace Lolchicer.Umlsql.Model;

interface IGetproperty
{
    public IMethod Method { get; }
    public IInterface Type { get; }
}
