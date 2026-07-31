namespace Lolchicer.Umlsql.Model.Automatons;

public interface IModel : Model.IModel
{
    public void Approve(IModel model);
    public void Cancel(IModel model);
}
