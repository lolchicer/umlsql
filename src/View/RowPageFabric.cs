using Lolchicer.Umlsql.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lolchicer.Umlsql.View
{
    public interface IRowPageFabric
    {
        public RowPage RowPage { get; }
    }

    public interface IRowPageFabric<T> : IRowPageFabric where T : ISettableRow
    {
        public RowPage RowPage { get; }
    }

    public class ModelsRowPageFabric : IRowPageFabric<ViewModel.Model>
    {
        IRowGetter<ViewModel.Model> _modelGetter;

        public RowPage RowPage => new RowPage(_modelGetter.Row);

        public ModelsRowPageFabric(IRowGetter<ViewModel.Model> modelGetter)
        {
            _modelGetter = modelGetter;
        }
    }

    public class ViewsRowPageFabric : IRowPageFabric<ViewModel.View>
    {
        IRowGetter<ViewModel.View> _viewGetter;

        public RowPage RowPage => new RowPage(_viewGetter.Row);

        public ViewsRowPageFabric(IRowGetter<ViewModel.View> viewGetter)
        {
            _viewGetter = viewGetter;
        }
    }
}
