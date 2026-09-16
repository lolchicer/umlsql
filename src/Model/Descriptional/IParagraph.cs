namespace Lolchicer.Umlsql.Model.Descriptional;

public interface IParagraph<T> : Core.IModel
{
    public Core.IModel Model { get; }
    public T Content { get; }
}
