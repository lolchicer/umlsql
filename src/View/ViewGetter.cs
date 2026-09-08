using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View;

public class ViewGetter(ApplicationContext context)
    : IModelGetter<ViewModel.Core.View>
{
    private ApplicationContext _context = context;

    public int Id { get; set; }

    public int ModelId { get; set; }

    public ViewModel.Core.View Model =>
        _context.Views.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);
}
