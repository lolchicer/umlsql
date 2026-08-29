namespace Lolchicer.Umlsql.ViewModel.Automatons;

public interface IModel : ViewModel.IModel
{
    public void Approve(Model model, Model type);
}
