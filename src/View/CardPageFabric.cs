using Lolchicer.Umlsql.View.Controls;

namespace Lolchicer.Umlsql.View;

public class CardPageFabric(IModelGetter<ViewModel.Documentational.Card> getter) : IModelPageFabric
{
    public ModelPage ModelPage => new(getter.Model);
}
