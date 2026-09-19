namespace Lolchicer.Umlsql.ViewModel.Descriptional;

public interface IAdditionalTermsParagraph : IParagraph, Model.Descriptional.IAdditionalTermsParagraph
{
    public new Core.IModel Model { get; }
    public new Core.IModel Type { get; }

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => Type;

    Model.Core.IModel
        Model.Descriptional.IAdditionalTermsParagraph.Model => Model;
    Model.Core.IModel
        Model.Descriptional.IAdditionalTermsParagraph.Type => Type;
}
