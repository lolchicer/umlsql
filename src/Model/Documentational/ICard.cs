namespace Lolchicer.Umlsql.Model.Documentational;

public interface ICard
{
    public Core.IModel Model { get; }
    public string Name { get; }
    public string Definition { get; }
}
