using Lolchicer.Umlsql.Model.Documentational;
using Lolchicer.Umlsql.View.Controls;
using Lolchicer.Umlsql.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Lolchicer.Umlsql.View
{
    public interface ICardGetter<T> where T : ICard
    {
        public T Card { get; }
    }

    public class CardGetter : ICardGetter<ViewModel.Documentational.Card>
    {
        private ApplicationContext _context;

        private CardIdBoxTuple _cardIdBoxTuple;

        public ViewModel.Documentational.Card Card => _context.Cards.Single(
            card =>
            card.Id == Convert.ToInt32(_cardIdBoxTuple.IdBox.Text) &&
            card.ModelId == Convert.ToInt32(_cardIdBoxTuple.ModelIdBox.Text)
        );

        public CardGetter(ApplicationContext context, CardIdBoxTuple cardIdBoxTuple)
        {
            _context = context;
            _cardIdBoxTuple = cardIdBoxTuple;
        }
    }
}
