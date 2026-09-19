namespace Lolchicer.Umlsql.ViewModel.Descriptional;

public interface IDateParagraph : IParagraph, Model.Descriptional.IDateParagraph
{
    public new Core.IModel Model { get; }
    public new Core.IModel Type { get; }

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => Type;

    Model.Core.IModel
        Model.Descriptional.IDateParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.IDateParagraph.Type => Type;
}
