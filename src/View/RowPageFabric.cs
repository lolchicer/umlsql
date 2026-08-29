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

    public class ModelsRowPageFabric : IRowPageFabric<ViewModel.Core.Model>
    {
        IRowGetter<ViewModel.Core.Model> _modelGetter;

        public RowPage RowPage => new RowPage(_modelGetter.Row);

        public ModelsRowPageFabric(IRowGetter<ViewModel.Core.Model> modelGetter)
        {
            _modelGetter = modelGetter;
        }
    }

    public class ViewsRowPageFabric : IRowPageFabric<ViewModel.Core.View>
    {
        IRowGetter<ViewModel.Core.View> _viewGetter;

        public RowPage RowPage => new RowPage(_viewGetter.Row);

        public ViewsRowPageFabric(IRowGetter<ViewModel.Core.View> viewGetter)
        {
            _viewGetter = viewGetter;
        }
    }
}
