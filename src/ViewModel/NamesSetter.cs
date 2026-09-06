namespace Lolchicer.Umlsql.ViewModel
{
    public interface INamesSetter<T> where T : INameable
    {
        public void SetNames(IEnumerable<T> ts);
    }   

    public class ApplicationNamesSetter :
        INamesSetter<Documentational.Card>
    {
        private ApplicationNameFabric _nameFabric;

        void INamesSetter<Documentational.Card>.SetNames(IEnumerable<Documentational.Card> cards)
        {
            foreach (var card in cards)
                card.Name = ((INameFabric<Core.Model>)_nameFabric).Name(card.Model);
        }

        public ApplicationNamesSetter(ApplicationNameFabric nameFabric)
        {
            _nameFabric = nameFabric;
        }
    }
}
