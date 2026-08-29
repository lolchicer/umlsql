namespace Lolchicer.Umlsql.Model.Automatons.Core;

public interface IModel : Model.Core.IModel
{
    public void Approve(IModel model);
    public void Cancel(IModel model);
}
