using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View.Controls;

public class CardGetter(ApplicationContext context, IIdTuple<ViewModel.Documentational.Card> tuple)
    : IModelGetter<ViewModel.Documentational.Card>
{
    public ViewModel.Documentational.Card Model => tuple.GetModel(context.Cards);
}
