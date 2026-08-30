using Lolchicer.Umlsql.Model.Documentational;
using Lolchicer.Umlsql.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lolchicer.Umlsql.View
{
    public interface ICardPageFabric
    {
        public CardPage CardPage { get; }
    }

    public interface ICardPageFabric<T> : ICardPageFabric where T : ICard { }

    public class CardPageFabric : ICardPageFabric<ViewModel.Documentational.Card>
    {
        ICardGetter<ViewModel.Documentational.Card> _cardGetter;

        public CardPage CardPage => new CardPage(_cardGetter.Card);

        public CardPageFabric(ICardGetter<ViewModel.Documentational.Card> cardGetter)
        {
            _cardGetter = cardGetter;
        }
    }
}
