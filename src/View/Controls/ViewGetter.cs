using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class ViewGetter(ApplicationContext context)
    : IModelGetterAsync<ViewModel.Core.View>
{
    private ApplicationContext _context = context;

    public int Id { get; set; }

    public int ModelId { get; set; }

    public async Task<ViewModel.Core.View> GetModel() =>
        _context.Views.First(
            model =>
            model.Id == Id &&
            model.ModelId == ModelId);
}
