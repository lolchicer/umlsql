using Lolchicer.Umlsql.Model.Documentational;

namespace Lolchicer.Umlsql.ViewModel
{
    public interface INamesSetter<T> where T : ICard
    {
        public void SetNames(IEnumerable<T> ts);
    }

    public class ApplicationNamesSetter :
        INamesSetter<Documentational.Card>
    {
        private ApplicationNameFabric _nameFabric;

        private void SetNames<T>(IEnumerable<T> cards, INameFabric<T> nameFabric)
            where T : ICard
        {
            foreach (var card in cards)
                card.Name = card.Name(nameFabric);
        }

        void INamesSetter<Documentational.Card>.SetNames(IEnumerable<Documentational.Card> cards) =>
            SetNames(cards, _nameFabric);

        public ApplicationNamesSetter(ApplicationNameFabric nameFabric)
        {
            _nameFabric = nameFabric;
        }
    }
}
