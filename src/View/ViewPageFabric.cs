using Lolchicer.Umlsql.View.Controls;

namespace Lolchicer.Umlsql.View;

public class ViewPageFabric(IModelGetterAsync<ViewModel.Core.View> getter) : IModelPageFabricAsync
{
    public async Task<ModelPage> GetModelPage() => new(await getter.GetModel());
}
