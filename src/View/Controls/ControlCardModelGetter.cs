using Lolchicer.Umlsql.View.Controls;
using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class ControlCardModelGetter(
    ApplicationContext context,
    CardIdBoxTuple cardIdBoxTuple)
    : IModelGetter<ViewModel.Documentational.Card>
{
    public ViewModel.Documentational.Card Model => context.Cards.Single(
        card =>
        card.Id == Convert.ToInt32(cardIdBoxTuple.IdBox.Text) &&
        card.ModelId == Convert.ToInt32(cardIdBoxTuple.ModelIdBox.Text)
    );
}
