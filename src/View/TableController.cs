using Lolchicer.Umlsql.View.Controls;
using Lolchicer.Umlsql.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lolchicer.Umlsql.View
{
    public interface ITableController
    {
        public void CreateNewRow();
    }

    public abstract class TableController<T>
        (ApplicationContext context) : ITableController where T : ISettableRow
    {
        protected ApplicationContext _context = context;

        protected abstract void AddNewRow();
        public void CreateNewRow()
        {
            AddNewRow();
            _context.SaveChanges();
        }
    }

    public class ModelTableController
        (ApplicationContext context, ModelIdBoxTuple modelIdBoxTuple)
        : TableController<ViewModel.Core.Model>(context)
    {
        protected ModelIdBoxTuple _modelIdBoxTuple = modelIdBoxTuple;

        protected override void AddNewRow() => _context.Models.Add(new ViewModel.Core.Model()
        {
            Id = Convert.ToInt32(_modelIdBoxTuple.IdBox.Text),
            Name = "123"
        });
    }

    public class ViewTableController
        (ApplicationContext context, ViewIdBoxTuple viewIdBoxTuple)
        : TableController<ViewModel.Core.View>(context)
    {
        protected ViewIdBoxTuple _viewIdBoxTuple = viewIdBoxTuple;

        protected override void AddNewRow() => _context.Views.Add(new ViewModel.Core.View()
        {
            Id = Convert.ToInt32(_viewIdBoxTuple.IdBox.Text),
            ModelId = Convert.ToInt32(_viewIdBoxTuple.IdBox.Text),
            TypeId = 1,
            Model = _context.Models.First(model => model.Id == Convert.ToInt32(_viewIdBoxTuple.IdBox.Text)),
            Type = _context.Models.First(type => type.Id == 1),
            Name = "123"
        });
    }
}
