namespace Lolchicer.Umlsql.ViewModel.Automatons.Core;

public interface IModel : Model.Core.IModel
{
    public void Approve(ViewModel.Core.Model model, ViewModel.Core.Model type);
}
