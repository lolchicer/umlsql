namespace Lolchicer.Umlsql.ViewModel.Core;

public interface IView : Umlsql.Model.Core.IView
{
    public new IModel Model { get; }
    public new IModel Type { get; }

    Umlsql.Model.Core.IModel
        Umlsql.Model.Core.IView.Model => Model;
    Umlsql.Model.Core.IModel
        Umlsql.Model.Core.IView.Type => Type;
}
