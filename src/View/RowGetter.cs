using Lolchicer.Umlsql.View.Controls;
using Lolchicer.Umlsql.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Lolchicer.Umlsql.View
{
    public interface IRowGetter<T> where T : IRow
    {
        public T Row { get; }
    }

    public class ModelGetter : IRowGetter<ViewModel.Model>
    {
        private ApplicationContext _context;

        private ModelIdBoxTuple _modelIdBoxTuple;

        public ViewModel.Model Row => _context.Models.Single(
            model =>
            model.Id == Convert.ToInt32(_modelIdBoxTuple.IdBox.Text)
        );

        public ModelGetter(ApplicationContext context, ModelIdBoxTuple modelIdBoxTuple)
        {
            _context = context;
            _modelIdBoxTuple = modelIdBoxTuple;
        }
    }

    public class ViewGetter : IRowGetter<ViewModel.View>
    {
        private ApplicationContext _context;

        private ViewIdBoxTuple _viewIdBoxTuple;

        public ViewModel.View Row => _context.Views.Single(
            view =>
            view.Id == Convert.ToInt32(_viewIdBoxTuple.IdBox.Text) &&
            view.ModelId == Convert.ToInt32(_viewIdBoxTuple.ModelIdBox.Text)
        );

        public ViewGetter(ApplicationContext context, ViewIdBoxTuple viewIdBoxTuple)
        {
            _context = context;
            _viewIdBoxTuple = viewIdBoxTuple;
        }
    }
}
