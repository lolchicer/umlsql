using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class DocumentIdBoxTuple
    : IIdBoxTuple<ViewModel.Documentational.Document>, ViewModel.Documentational.IDocumentIdTuple
{
    private readonly TextBox _idBox;
    private readonly TextBox _modelIdBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public TextBox IdBox => _idBox;
    public TextBox ModelIdBox => _modelIdBox;

    public int Id => Convert.ToInt32(IdBox.Text);
    public int ModelId => Convert.ToInt32(ModelIdBox.Text);

    public DocumentIdBoxTuple()
    {
        _idBox = new();
        _modelIdBox = new();
        _idBoxes = [_idBox, _modelIdBox];
    }
}
