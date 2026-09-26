using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class ViewIdBoxTuple
    : IIdBoxTuple<ViewModel.Core.View>, ViewModel.Core.INewViewIdTuple
{
    private readonly TextBox _idBox;
    private readonly TextBox _modelIdBox;
    private readonly TextBox _typeIdBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public TextBox IdBox => _idBox;
    public TextBox ModelIdBox => _modelIdBox;
    public TextBox TypeIdBox => _typeIdBox;

    public int Id => Convert.ToInt32(IdBox.Text);
    public int ModelId => Convert.ToInt32(ModelIdBox.Text);
    public int TypeId => Convert.ToInt32(TypeIdBox.Text);

    public ViewIdBoxTuple()
    {
        _idBox = new();
        _modelIdBox = new();
        _typeIdBox = new();
        _idBoxes = [_idBox, _modelIdBox, _typeIdBox];
    }
}
