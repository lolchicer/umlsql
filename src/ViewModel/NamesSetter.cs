using System;
using System.Collections.Generic;
using System.Text;

namespace Lolchicer.Umlsql.ViewModel
{
    public interface INamedTuplesFabric<T> : IAsyncEnumerable<Tuple<T, string>> where T : ISettableRow
    {

    }

    public class NamedTuplesFabric<T> : INamedTuplesFabric<T> where T : ISettableRow
    {
        private IAsyncEnumerable<T> _rows;
        private INameFabric<T> _nameFabric;

        public IAsyncEnumerator<Tuple<T, string>> GetAsyncEnumerator(CancellationToken cancellationToken) => (
            from row in _rows
            select new Tuple<T, string>(row, _nameFabric.Name(row))
            ).GetAsyncEnumerator(cancellationToken);

        public NamedTuplesFabric(IAsyncEnumerable<T> rows, INameFabric<T> nameFabric)
        {
            _rows = rows;
            _nameFabric = nameFabric;
        }
    }
}
