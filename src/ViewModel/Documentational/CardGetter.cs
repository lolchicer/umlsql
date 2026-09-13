namespace Lolchicer.Umlsql.ViewModel.Documentational;

public class CardGetter(ApplicationContext context, IIdTuple<Card> tuple)
    : IModelGetter<Card>
{
    public Card Model => tuple.GetModel(context.Cards);
}
