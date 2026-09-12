using Lolchicer.Umlsql.View.Controls;

namespace Lolchicer.Umlsql.View;

public class CardPageFabric(IModelGetterAsync<ViewModel.Documentational.Card> getter) : IModelPageFabricAsync
{
    public async Task<ModelPage> GetModelPage() => new(await getter.GetModel());
}
