namespace Lolchicer.Umlsql.ViewModel.Iterational;

public interface IRedaction : Core.IView, Model.Iterational.IRedaction
{
    public new Core.IModel Model { get; }
    public new Core.IModel Type { get; }

    Core.IModel
        Core.IView.Model => Model;
    Core.IModel
        Core.IView.Type => Type;

    Model.Core.IModel
        Model.Core.IView.Model => Model;
    Model.Core.IModel
        Model.Core.IView.Type => Type;

    Model.Core.IModel
        Model.Iterational.IRedaction.Model => Model;
    Model.Core.IModel
        Model.Iterational.IRedaction.Type => Type;
}
