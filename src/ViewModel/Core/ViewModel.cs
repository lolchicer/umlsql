namespace Lolchicer.Umlsql.ViewModel.Core;

public interface IModel : IRow, Umlsql.Model.Core.IModel { }

public interface IView : IRow, Umlsql.Model.Core.IView
{
    new public IModel Model { get; }
    new public IModel Type { get; }
    Umlsql.Model.Core.IModel Umlsql.Model.Core.IView.Model => Model;
    Umlsql.Model.Core.IModel Umlsql.Model.Core.IView.Type => Type;
}
