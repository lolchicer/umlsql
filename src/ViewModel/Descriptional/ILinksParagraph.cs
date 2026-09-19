namespace Lolchicer.Umlsql.ViewModel.Descriptional;

public interface ILinksParagraph : IParagraph, Model.Descriptional.ILinksParagraph
{
    public new Core.IModel Model { get; }
    public new Core.IModel Type { get; }

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => Type;

    Model.Core.IModel
        Model.Descriptional.ILinksParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.ILinksParagraph.Type => Type;
}
