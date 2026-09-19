namespace Lolchicer.Umlsql.ViewModel.Descriptional;

public interface IParagraph : Core.IView, Model.Descriptional.IParagraph
{
    public new Core.IModel Model { get; }
    public new Core.IModel Type { get; }

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => Type;

    Model.Core.IModel
        Model.Descriptional.IParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.IParagraph.Type => Type;
}
