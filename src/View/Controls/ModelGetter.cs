using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class ModelGetter(ApplicationContext context)
    : IModelGetterAsync<ViewModel.Core.Model>
{
    private ApplicationContext _context = context;

    public int Id { get; set; }

    public async Task<ViewModel.Core.Model> GetModel() =>
        (await _context.Models).First(
            model =>
            model.Id == Id);
}
