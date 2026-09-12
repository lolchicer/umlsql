using Lolchicer.Umlsql.View.Controls;
using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class ControlCardModelGetter(
    ApplicationContext context,
    CardIdBoxTuple cardIdBoxTuple)
    : IModelGetterAsync<ViewModel.Documentational.Card>
{
    public async Task<ViewModel.Documentational.Card> GetModel() => (await context.Cards).Single(
        card =>
        card.Id == Convert.ToInt32(cardIdBoxTuple.IdBox.Text) &&
        card.ModelId == Convert.ToInt32(cardIdBoxTuple.ModelIdBox.Text)
    );
}
