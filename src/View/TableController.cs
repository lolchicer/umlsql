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
        (ApplicationContext context, ViewModel.Core.INewViewIdTuple idBoxTuple)
        : TableController(context)
    {
        private readonly ViewModel.Core.INewViewIdTuple _idBoxTuple = idBoxTuple;

        protected override void AddNewRow() =>
            _idBoxTuple.GetModel(_context.Models)
            .Views
            .Add(new ViewModel.Core.View()
            {
                Id = _idBoxTuple.Id,
                ModelId = _idBoxTuple.ModelId,
                TypeId = _idBoxTuple.TypeId,
                Model = _idBoxTuple.GetModel(_context.Models)
            });
    }

    public class RedactionTableController
        (ApplicationContext context, ViewModel.Iterational.INewRedactionIdTuple idBoxTuple)
        : TableController(context)
    {
        private readonly ViewModel.Iterational.INewRedactionIdTuple _idBoxTuple = idBoxTuple;

        protected override void AddNewRow() =>
            _idBoxTuple.GetModel(_context.Models)
            .Redactions
            .Add(new ViewModel.Iterational.Redaction()
            {
                Id = _idBoxTuple.Id,
                ModelId = _idBoxTuple.ModelId,
                TypeId = _idBoxTuple.TypeId,
                Model = _idBoxTuple.GetModel(_context.Models),
            });
    }

    public class DocumentTableController
        (ApplicationContext context, ViewModel.Documentational.INewDocumentIdTuple idBoxTuple)
        : TableController(context)
    {
        private readonly ViewModel.Documentational.INewDocumentIdTuple _idBoxTuple = idBoxTuple;

        protected override void AddNewRow() =>
            _idBoxTuple.GetModel(_context.Models)
            .Documents
            .Add(new ViewModel.Documentational.Document()
            {
                Id = _idBoxTuple.Id,
                ModelId = _idBoxTuple.ModelId,
                Model = _idBoxTuple.GetModel(_context.Models),
                DocumentTypeId = _idBoxTuple.DocumentTypeId,
                AdditionalTermsTypeId = _idBoxTuple.AdditionalTermsTypeId,
                DateTypeId = _idBoxTuple.DateTypeId,
                LinksTypeId = _idBoxTuple.LinksTypeId,
                NameTypeId = _idBoxTuple.NameTypeId,
                ViewsTypeId = _idBoxTuple.ViewsTypeId,
                AdditionalTermsContent = "безрассудство",
                DateContent = DateTime.Now,
                ViewsContent = "как",
                LinksContent = "всегда",
                NameContent = "вознаграждается"
            });
    }
}
