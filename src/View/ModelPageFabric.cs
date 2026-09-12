using Lolchicer.Umlsql.View.Controls;

namespace Lolchicer.Umlsql.View;

public class ModelPageFabric(IModelGetterAsync<ViewModel.Core.Model> getter) : IModelPageFabricAsync
{
    public async Task<ModelPage> GetModelPage() => new(await getter.GetModel());
}
