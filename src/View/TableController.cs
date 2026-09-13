using Lolchicer.Umlsql.ViewModel;

namespace Lolchicer.Umlsql.View
{
    public interface ITableController
    {
        public void CreateNewCard();
    }

    public abstract class TableController
        (ApplicationContext context) : ITableController
    {
        protected ApplicationContext _context = context;

        protected abstract void AddNewRow();
        public void CreateNewCard()
        {
            AddNewRow();
            _context.SaveChanges();
        }
    }

    public class ModelTableController
        (ApplicationContext context, ViewModel.Core.IModelIdTuple idBoxTuple)
        : TableController(context)
    {
        private readonly ViewModel.Core.IModelIdTuple _iIdBoxTuple = idBoxTuple;

        protected override void AddNewRow() =>
            _context.Models.Add(new ViewModel.Core.Model()
            {
                Id = _iIdBoxTuple.Id
            });
    }

    public class ViewTableController
        (ApplicationContext context, ViewModel.Core.IViewIdTuple idBoxTuple)
        : TableController(context)
    {
        private readonly ViewModel.Core.IViewIdTuple _idBoxTuple = idBoxTuple;

        protected override void AddNewRow() =>
            _idBoxTuple.GetModel(_context.Models)
            .Views
            .Add(new ViewModel.Core.View()
            {
                Id = _idBoxTuple.Id,
                ModelId = _idBoxTuple.ModelId,
                TypeId = 1,
                Model = _idBoxTuple.GetModel(_context.Models),
                Type = _context.Models.First(type => type.Id == 1)
            });
    }

    public class CardTableController
        (ApplicationContext context, ViewModel.Documentational.ICardIdTuple idBoxTuple)
        : TableController(context)
    {
        private readonly ViewModel.Documentational.ICardIdTuple _idBoxTuple = idBoxTuple;

        protected override void AddNewRow() =>
            _idBoxTuple.GetModel(_context.Models)
            .Cards
            .Add(new ViewModel.Documentational.Card()
            {
                Id = _idBoxTuple.Id,
                ModelId = _idBoxTuple.ModelId,
                Model = _idBoxTuple.GetModel(_context.Models),
                Definition = "твоя ошибка",
                Name = "123"
            });
    }
}
