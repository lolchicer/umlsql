using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public interface IIdBoxTuple<T> where T : ViewModel.Core.IModel
{
    public IEnumerable<TextBox> IdBoxes { get; }

    public T Model { get; }
}
