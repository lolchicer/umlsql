namespace Lolchicer.Umlsql.ViewModel;

public interface IModel : IRow, Umlsql.Model.IModel { }

public interface IView : IRow, Umlsql.Model.IView
{
    new public IModel Model { get; }
    new public IModel Type { get; }
    Umlsql.Model.IModel Umlsql.Model.IView.Model => Model;
    Umlsql.Model.IModel Umlsql.Model.IView.Type => Type;
}
