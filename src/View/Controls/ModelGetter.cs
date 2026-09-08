using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class ModelGetter(ApplicationContext context)
    : IModelGetter<ViewModel.Core.Model>
{
    private ApplicationContext _context = context;

    public int Id { get; set; }

    public ViewModel.Core.Model Model =>
        _context.Models.First(
            model =>
            model.Id == Id);
}
