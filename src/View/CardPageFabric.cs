namespace Lolchicer.Umlsql.View;

public class CardPageFabric(ViewModel.IModelGetter<ViewModel.Documentational.Card> getter) : IModelPageFabric
{
    public ModelPage ModelPage => new(getter.Model);
}
