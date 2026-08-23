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

        public ViewModel.Model Row => (
            from model in _context.Models
            where model.Id == Convert.ToInt32(_modelIdBoxTuple.IdBox.Text)
            select model
        ).First();

        public ModelGetter(ApplicationContext context, ModelIdBoxTuple modelIdBoxTuple)
        {
            _context = context;
            _modelIdBoxTuple = modelIdBoxTuple;
        }
    }
}
