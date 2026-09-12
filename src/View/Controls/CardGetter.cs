using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class CardGetter(ApplicationContext context)
    : IModelGetterAsync<ViewModel.Documentational.Card>
{
    private ApplicationContext _context = context;

    public int Id { get; set; }

    public int ModelId { get; set; }

    public async Task<ViewModel.Documentational.Card> GetModel() =>
        _context.Cards.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);
}
