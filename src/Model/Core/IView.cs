namespace Lolchicer.Umlsql.Model.Core;

public interface IView : IModel
{
    public IModel Model { get; }
    public IModel Type { get; } 
}
