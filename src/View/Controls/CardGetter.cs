using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class CardGetter(ApplicationContext context)
    : IModelGetter<ViewModel.Documentational.Card>
{
    private ApplicationContext _context = context;

    public int Id { get; set; }

    public int ModelId { get; set; }

    public ViewModel.Documentational.Card Model =>
        _context.Cards.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);
}
