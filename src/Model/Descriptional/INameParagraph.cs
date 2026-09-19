namespace Lolchicer.Umlsql.Model.Descriptional;

public interface INameParagraph : IParagraph
{
    public new Core.IModel Model { get; }
    public new Core.IModel Type { get; }

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => Type;
}
