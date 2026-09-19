namespace Lolchicer.Umlsql.Model.Iterational;

public interface IRedaction : Core.IView
{
    public new Core.IModel Model { get; }
    public new Core.IModel Type { get; }

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => Type;
}
